namespace Bartender.Net.Framework.REST {
    public interface ISingleSelectionApiResponse {
        object? Content { get; set; }
        int Error { get; set; }
        HttpResponseMessage? HttpResponseMessage { get; set; }

        bool IsValid ();
        T? TryGetContent<T> (out bool valid) where T : class;
    }
}