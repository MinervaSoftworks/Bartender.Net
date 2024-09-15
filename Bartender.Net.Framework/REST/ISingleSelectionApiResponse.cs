using Bartender.Net.Framework;

namespace Bartender.Net.REST {
    public interface ISingleSelectionApiResponse<T> where T : IBartenderEntity {
        T Content { get; set; }
        int Error { get; set; }
        HttpResponseMessage? HttpResponseMessage { get; set; }

        bool IsValid ();
    }
}