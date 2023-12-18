using System.Net.Http.Headers;

namespace TornApi.Net.REST {
    /// <summary>
    /// A request client to interact with Torn's REST Api.
    /// </summary>
    public class ApiRequestClient (IHttpClientFactory clientFactory) {
        private IHttpClientFactory _clientFactory = clientFactory;

        public async Task<HttpResponseMessage?> GetAsync(RequestConfiguration config) {
            using var client = _clientFactory.CreateClient ("src");

            client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));

            client.BaseAddress = new Uri (config.ApiUrl);

            return await client.GetAsync (config.ToString ());
        }
    }
}
