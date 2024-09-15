using Bartender.Net.Framework;

namespace Bartender.Net.REST;

public class SingleSelectionApiResponse<T> : ISingleSelectionApiResponse<T> where T : IBartenderEntity {
    public HttpResponseMessage? HttpResponseMessage { get; set; }

    public int Error { get; set; } = -1;

    public T Content { get; set; } = default!;

    public bool IsValid () => !(HttpResponseMessage is null || !HttpResponseMessage.IsSuccessStatusCode) && Content is not null;
}
