using FluentAssertions;
using haphaestusBe.DataProviders;
using haphaestusBe.Models;
using Microsoft.Azure.WebJobs.Host;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace haphaestusBe.Test
{
    [TestFixture]
    public class AddEmployeeTests
    {
        private IEmployeeDataProvider _employeeDataProvider;
        private IHttpResponseCreator _httpResponseCreator;

        private TraceWriter _traceWriter;

        [SetUp]
        public void Setup()
        {
            _httpResponseCreator = Mock.Of<IHttpResponseCreator>();
            _employeeDataProvider = Mock.Of<IEmployeeDataProvider>();

            _traceWriter = new TraceWriterFake();

            InjectionFactory.UseIHttpResponseCreator(_httpResponseCreator);
            InjectionFactory.UseIEmployeeDataProvider(_employeeDataProvider);
        }

        [Test]
        public async Task AddEmployee_HappyPath_AddsEmployeeAndReturnsCorrectResponse()
        {
            // Arrange
            var employee = CreateEmployee();
            var request = CreateRequestWithEmployee(employee);
            var expectedResponse = new HttpResponseMessage();

            Mock.Get(_httpResponseCreator)
                .Setup(m => m.CreateHttpResponse<Employee>(request, System.Net.HttpStatusCode.OK, It.IsAny<Employee>()))
                .Returns(expectedResponse);

            // Act
            var response = await AddEmployee.Run(request, _traceWriter);

            // Assert
            response.Should().Be(expectedResponse);
            Mock.Get(_employeeDataProvider).Verify(m => m.AddEmployee(It.Is((Employee e) => e.Name.FirstName == employee.Name.FirstName)), Times.Once);
        }

        private Employee CreateEmployee()
        {
            var employee = new Employee(0, new PersonName("Brian", "McBrayer"), false, new PersonName(string.Empty, string.Empty), new List<PersonName>());

            return employee;
        }

        private HttpRequestMessage CreateRequestWithEmployee(Employee employee)
        {
            var jsonEmployee = JsonConvert.SerializeObject(employee);

            var req = new HttpRequestMessage();
            req.Content = new StringContent(jsonEmployee, System.Text.Encoding.ASCII, "text/json");

            return req;
        }

        private class TraceWriterFake : TraceWriter
        {
            public TraceWriterFake() : base(TraceLevel.Off)
            {
            }

            public override void Trace(TraceEvent traceEvent)
            {
                ; // noop
            }
        }
    }
}
