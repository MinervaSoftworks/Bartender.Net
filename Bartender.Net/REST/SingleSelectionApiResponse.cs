using Bartender.Net.Framework.REST;

namespace Bartender.Net.REST;

public class SingleSelectionApiResponse : ISingleSelectionApiResponse {
    public HttpResponseMessage? HttpResponseMessage { get; set; }

    public int Error { get; set; } = -1;

    public object? Content { get; set; } = default!;

    public bool IsValid () => !(HttpResponseMessage is null || !HttpResponseMessage.IsSuccessStatusCode) && Content is not null;
}
