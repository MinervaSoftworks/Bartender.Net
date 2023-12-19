namespace TornApi.Net.REST {
    public class ApiResponse<T> {
        public T? Content { get; set; } = default;

        public KeyValidationStatus KeyStatus { get; set; } = new KeyValidationStatus ();

        public HttpResponseMessage? HttpResponseMessage { get; set; }
    }
}
