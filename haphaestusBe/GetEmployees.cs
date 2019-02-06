using haphaestusBe.DataProviders;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using System.Net;
using System.Net.Http;
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
            var employeesDataProvider = InjectionFactory.GetIEmployeeDataProvider();
            var httpResponseCreator = InjectionFactory.GetIHttpResponseCreator();

            var employees = await employeesDataProvider.GetEmployees();

            return httpResponseCreator.CreateHttpResponse(req, HttpStatusCode.OK, employees);
        }
    }
}
