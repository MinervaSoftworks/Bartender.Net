using Bartender.Net.Framework.REST;

namespace Bartender.Net.REST {
    public class ApiResponse<T> : IApiResponse<T> {
        public T? Content { get; set; } = default;

        public IKeyValidationStatus KeyStatus { get; set; } = new KeyValidationStatus ();

        public HttpResponseMessage? HttpResponseMessage { get; set; }

        public bool IsValid () {
            if (!KeyStatus.IsKeyUsable
                || (HttpResponseMessage is null || !HttpResponseMessage.IsSuccessStatusCode)
                || Content is null) {
                return false;
            }

            return true;
        }
    }
}
