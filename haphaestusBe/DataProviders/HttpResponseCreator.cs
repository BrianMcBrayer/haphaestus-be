using Newtonsoft.Json.Serialization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace haphaestusBe.DataProviders
{
    /// <summary>
    /// Creates an Http Response
    /// </summary>
    public class HttpResponseCreator : IHttpResponseCreator
    {
        private readonly JsonMediaTypeFormatter _jsonFormatter;

        /// <summary>
        /// Constructor for <see cref="HttpResponseCreator"/>
        /// </summary>
        public HttpResponseCreator()
        {
            _jsonFormatter = new JsonMediaTypeFormatter
            {
                SerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                },
                UseDataContractJsonSerializer = false
            };
        }

        /// <summary>
        /// Creates an http response using the given <paramref name="req"/>, <paramref name="httpStatusCode"/>, and <paramref name="value"/>
        /// </summary>
        /// <typeparam name="T">The type of the object in the response</typeparam>
        /// <param name="req">The <see cref="HttpRequestMessage"/> used to create the response</param>
        /// <param name="httpStatusCode">The <see cref="HttpStatusCode"/> to use in the reponse</param>
        /// <param name="value">The response data</param>
        public HttpResponseMessage CreateHttpResponse<T>(HttpRequestMessage req, HttpStatusCode httpStatusCode, T value)
        {
            return req.CreateResponse(httpStatusCode, value, _jsonFormatter);
        }
    }
}
