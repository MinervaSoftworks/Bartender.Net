using System.Net.Http.Headers;

namespace TornApi.Net.REST {
    /// <summary>
    /// A short-lived REST client. A new client must be created after each request as the internal client is disposed of after use.
    /// </summary>
    public class SingleRequestClient (IHttpClientFactory clientFactory) {
        private IHttpClientFactory _clientFactory = clientFactory;

        public async Task<HttpResponseMessage?> GetAsync(RequestConfiguration config) {
            using var client = _clientFactory.CreateClient ("src");

            client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));

            client.BaseAddress = new Uri (config.ApiUrl);

            return await client.GetAsync (config.ToString ());
        }
    }
}
