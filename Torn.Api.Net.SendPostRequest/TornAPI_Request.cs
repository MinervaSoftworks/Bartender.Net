using System.Text;
using System.Net.Http.Headers;

using Newtonsoft.Json;

using Torn.Api.Net.Framework;
using Torn.Api.Net.Models.User;

namespace Torn.Api.Net.SendPostRequest;

public class TornAPI_Request
{
    public string apiKey { get; set; }
    public string userId { get; set; }
    public string section { get; set; }
    public string comment { get; set; }
    public string [] selections = [];
}

