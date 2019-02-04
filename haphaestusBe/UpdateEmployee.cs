using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
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
        [FunctionName("UpdateEmployee")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            var employeeToUpdate = await req.Content.ReadAsAsync<Employee>();

            string connectionString = ConfigurationManager.AppSettings["MongoDBConnectionString"];
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("haphaestusdata");
            var collection = database.GetCollection<Employee>("Employees");

            await collection.ReplaceOneAsync(e => e.Id == employeeToUpdate.Id, employeeToUpdate);

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
