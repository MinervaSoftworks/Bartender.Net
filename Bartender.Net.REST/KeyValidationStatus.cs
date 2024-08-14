using System.Net;

namespace Bartender.Net.REST {
    public class KeyValidationStatus : IKeyValidationStatus {
        public bool IsValid { get; set; } = false;

        public bool HasRequiredAccessLevel { get; set; } = false;

        public int ErrorCode { get; set; } = 0;

        public HttpStatusCode HttpStatusCode { get; set; } = HttpStatusCode.OK;

        public bool IsKeyUsable => IsValid && HasRequiredAccessLevel;
    }
}
