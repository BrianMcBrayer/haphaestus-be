using haphaestusBe.DataProviders;
using haphaestusBe.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace haphaestusBe
{
    public static class AddEmployee
    {
        /// <summary>
        /// Adds an employee
        /// </summary>
        /// <param name="req">The request data</param>
        /// <param name="log">The logger</param>
        /// <returns>Returns a response with the added employee</returns>
        [FunctionName("AddEmployee")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            var employeeDataProvider = InjectionFactory.GetIEmployeeDataProvider();
            var httpResponseCreator = InjectionFactory.GetIHttpResponseCreator();

            var newEmployee = await req.Content.ReadAsAsync<Employee>();

            await employeeDataProvider.AddEmployee(newEmployee);

            return httpResponseCreator.CreateHttpResponse(req, HttpStatusCode.OK, newEmployee);
        }
    }
}
