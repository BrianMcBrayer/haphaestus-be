using haphaestusBe.DataProviders;
using haphaestusBe.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using MongoDB.Driver;
using Newtonsoft.Json.Serialization;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace haphaestusBe
{
    public static class GetEmployees
    {
        /// <summary>
        /// Gets all employees, sorted by last name and then by first name. Note that sorting is case sensitive.
        /// </summary>
        /// <param name="req">The request</param>
        /// <param name="log">The logger</param>
        /// <returns>Returns a response with all the employees</returns>
        [FunctionName("GetEmployees")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            var employeesDataProvider = new EmployeeDataProvider();

            var employees = await employeesDataProvider.GetEmployees();

            return req.CreateResponse(HttpStatusCode.OK, employees, new JsonMediaTypeFormatter
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
