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
        [FunctionName("GetEmployees")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            string connectionString = ConfigurationManager.AppSettings["MongoDBConnectionString"];
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("haphaestusdata");
            var collection = database.GetCollection<Employee>("Employees");

            var employees = await collection
                .FindAsync(filter => true, new FindOptions<Employee, Employee>
                {
                    Sort = Builders<Employee>.Sort
                        .Ascending(e => e.Name.LastName)
                        .Ascending(e => e.Name.FirstName)
                });

            return req.CreateResponse(HttpStatusCode.OK, employees.ToEnumerable(), new JsonMediaTypeFormatter
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
