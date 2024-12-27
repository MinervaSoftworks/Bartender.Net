using Bartender.Net.Framework.REST;

namespace Bartender.Net.REST;

public class SingleSelectionApiResponse : ISingleSelectionApiResponse {
    public HttpResponseMessage? HttpResponseMessage { get; set; }

    public int Error { get; set; } = -1;

    public object? Content { get; set; } = default!;

    public bool IsValid () => !(HttpResponseMessage is null || !HttpResponseMessage.IsSuccessStatusCode) && Content is not null;

    public T? TryGetContent<T> (out bool valid) where T : class {
        if (IsValid () && Content is T content) {
            valid = true;
            return content;
        }

        valid = false;
        return null;
    }
}
