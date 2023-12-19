using System.Net;

namespace TornApi.Net.REST {
    public class KeyValidationStatus {
        public bool IsValid { get; set; } = false;

        public bool HasRequiredAccessLevel { get; set; } = false;

        public int ErrorCode { get; set; } = 0;

        public HttpStatusCode HttpStatusCode { get; set; } = HttpStatusCode.OK;
    }
}
