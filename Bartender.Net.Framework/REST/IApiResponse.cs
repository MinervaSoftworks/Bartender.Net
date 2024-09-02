namespace Bartender.Net.Framework.REST;

public interface IApiResponse<T> {
    T? Content { get; set; }
    HttpResponseMessage? HttpResponseMessage { get; set; }
    IKeyValidationStatus KeyStatus { get; set; }

    bool IsValid ();
}