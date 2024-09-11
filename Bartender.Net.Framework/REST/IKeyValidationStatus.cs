using System.Net;

namespace Bartender.Net.Framework.REST;

public interface IKeyValidationStatus {
    IApiResponse? Response { get; set; }
    bool IsValid { get; set; }
    bool HasRequiredAccessLevel { get; set; }
    bool IsUsable { get; }
}