using haphaestusBe.DataProviders;
using haphaestusBe.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using MongoDB.Driver;
using Newtonsoft.Json.Serialization;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
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
            // Refactor this to DI when Azure Functions supports it
            var employeeDataProvider = new EmployeeDataProvider();
            var newEmployee = await req.Content.ReadAsAsync<Employee>();

            await employeeDataProvider.AddEmployee(newEmployee);

            return req.CreateResponse(HttpStatusCode.OK, newEmployee, new JsonMediaTypeFormatter
            {
                SerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                },
                UseDataContractJsonSerializer = false
            });
        }
    }
}
