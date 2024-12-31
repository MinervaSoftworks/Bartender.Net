namespace Bartender.Net.Framework.REST;

public interface IApiResponse {
    HttpResponseMessage? HttpResponseMessage { get; set; }

    object? Content { get; set; }

    int Error { get; set; }

    string Json { get; set; }

    bool IsValid ();

    T? TryGetContent<T> () where T : class;
}