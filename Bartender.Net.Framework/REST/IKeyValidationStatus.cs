using System.Net;

namespace Bartender.Net.Framework.REST;

public interface IKeyValidationStatus {
    int ErrorCode { get; set; }
    bool HasRequiredAccessLevel { get; set; }
    HttpStatusCode HttpStatusCode { get; set; }
    bool IsKeyUsable { get; }
    bool IsValid { get; set; }
}