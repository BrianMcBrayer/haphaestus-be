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
            var employeeDataProvider = InjectionFactory.GetIEmployeeDataProvider();
            var httpResponseCreator = InjectionFactory.GetIHttpResponseCreator();

            var employeeToUpdate = await req.Content.ReadAsAsync<Employee>();

            await employeeDataProvider.UpdateEmployee(employeeToUpdate);

            return httpResponseCreator.CreateHttpResponse(req, HttpStatusCode.OK, employeeToUpdate);
        }
    }
}
