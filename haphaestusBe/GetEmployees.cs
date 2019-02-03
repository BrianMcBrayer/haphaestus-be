using haphaestusBe.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json.Serialization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace haphaestusBe
{
    public static class GetEmployees
    {
        [FunctionName("GetEmployees")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("GET function called");

            return req.CreateResponse(HttpStatusCode.OK, MockEmployees.Employees, new JsonMediaTypeFormatter
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
