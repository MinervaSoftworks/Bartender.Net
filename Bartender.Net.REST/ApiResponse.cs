using Bartender.Net.Framework.REST;

namespace Bartender.Net.REST {
    public class ApiResponse<T> : IApiResponse<T> {
        public T? Content { get; set; } = default;

        public HttpResponseMessage? HttpResponseMessage { get; set; }

        public bool IsValid () {
            if ((HttpResponseMessage is null || !HttpResponseMessage.IsSuccessStatusCode)
                || Content is null) {
                return false;
            }

            return true;
        }
    }
}
