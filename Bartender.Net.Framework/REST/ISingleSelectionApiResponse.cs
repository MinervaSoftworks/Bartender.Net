namespace Bartender.Net.Framework.REST {
    public interface ISingleSelectionApiResponse<T> where T : BartenderEntity {
        T? Content { get; set; }
        int Error { get; set; }
        HttpResponseMessage? HttpResponseMessage { get; set; }

        bool IsValid ();
    }
}