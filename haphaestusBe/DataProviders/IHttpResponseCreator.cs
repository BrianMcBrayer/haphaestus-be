using System.Net;
using System.Net.Http;

namespace haphaestusBe.DataProviders
{
    /// <summary>
    /// Creates an Http Response
    /// </summary>
    public interface IHttpResponseCreator
    {
        /// <summary>
        /// Creates an http response using the given <paramref name="req"/>, <paramref name="httpStatusCode"/>, and <paramref name="value"/>
        /// </summary>
        /// <typeparam name="T">The type of the object in the response</typeparam>
        /// <param name="req">The <see cref="HttpRequestMessage"/> used to create the response</param>
        /// <param name="httpStatusCode">The <see cref="HttpStatusCode"/> to use in the reponse</param>
        /// <param name="value">The response data</param>
        HttpResponseMessage CreateHttpResponse<T>(HttpRequestMessage req, HttpStatusCode httpStatusCode, T value);
    }
}