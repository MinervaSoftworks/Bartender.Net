namespace Bartender.Net.Framework.REST;

public interface IKeyValidationStatus {
    IApiResponse? Result { get; set; }
    bool IsValid { get; set; }
    bool HasRequiredAccessLevel { get; set; }
    bool IsUsable { get; }
}