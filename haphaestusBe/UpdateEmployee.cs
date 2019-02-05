using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using haphaestusBe.DataProviders;
using haphaestusBe.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using MongoDB.Driver;
using Newtonsoft.Json.Serialization;

namespace haphaestusBe
{
    public static class UpdateEmployee
    {
        /// <summary>
        /// Updates a single existing employee
        /// </summary>
        /// <param name="req">The request containing the existing employee</param>
        /// <param name="log">The logger</param>
        /// <returns>Returns a response with the updated employee</returns>
        [FunctionName("UpdateEmployee")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            // when Azure Functions allows dependency injection natively, refactor this
            var employeeService = new EmployeeDataProvider();
            var employeeToUpdate = await req.Content.ReadAsAsync<Employee>();

            await employeeService.UpdateEmployee(employeeToUpdate);

            return req.CreateResponse(HttpStatusCode.OK, employeeToUpdate, new JsonMediaTypeFormatter
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
