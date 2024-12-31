using Bartender.Net.Framework.REST;

namespace Bartender.Net.REST;

public class ApiResponse : IApiResponse {
    public HttpResponseMessage? HttpResponseMessage { get; set; }

    public object? Content { get; set; } = new ();

    public string Json { get; set; } = string.Empty;

    public int Error { get; set; } = -1;

    public bool IsValid () => !(HttpResponseMessage is null || !HttpResponseMessage.IsSuccessStatusCode) && Content is not null;

    public T? TryGetContent<T> () where T : class {
        if (IsValid () && Content is T content) {
            return content;
        }

        return null;
    }
}
