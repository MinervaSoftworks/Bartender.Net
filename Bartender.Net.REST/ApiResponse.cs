using Bartender.Net.Framework.REST;
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.REST {
    public class ApiResponse : IApiResponse {
        public HttpResponseMessage? HttpResponseMessage { get; set; }

        public int Error { get; set; } = -1;

        public IDictionary<Selection, object> Content { get; set; } = new Dictionary<Selection, object> ();

        public bool IsValid () => !(HttpResponseMessage is null || !HttpResponseMessage.IsSuccessStatusCode) && Content is not null;
    }
}
