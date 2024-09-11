using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Framework.REST;

public interface IApiResponse {
    HttpResponseMessage? HttpResponseMessage { get; set; }

    IDictionary<Selection, object> Content { get; set; }
    int Error { get; set; }

    bool IsValid ();
}