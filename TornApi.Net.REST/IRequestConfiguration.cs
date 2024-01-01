
namespace TornApi.Net.REST {
    public interface IRequestConfiguration {
        string? Comment { readonly get; set; }
        DateTime? From { readonly get; set; }
        int ID { readonly get; set; }
        string Key { readonly get; set; }
        int? Limit { readonly get; set; }
        string Section { readonly get; set; }
        IEnumerable<string> Selections { readonly get; set; }
        string? Sort { readonly get; set; }
        DateTime? To { readonly get; set; }

        string ToString ();
    }
}