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
        [FunctionName("AddEmployee")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            var newEmployee = await req.Content.ReadAsAsync<Employee>();

            newEmployee.Id = new Random().Next(1_000_000_000);

            string connectionString = ConfigurationManager.AppSettings["MongoDBConnectionString"];
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("HaphaestusData");
            var collection = database.GetCollection<Employee>("Employees");

            await collection.InsertOneAsync(newEmployee);

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
