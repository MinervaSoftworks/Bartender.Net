using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.Common.User;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.Common.User;

public class RelativeLastAction : IRelativeLastAction {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("status")]
    public required string Status { get; set; }

    [JsonProperty ("relative")]
    public required string Relative { get; set; }

    public LastActionStatus LastActionStatus {
        get => Status.ToLastActionStatus ();
        set => Status = value.ToLastActionStatusString ();
    }

    [JsonProperty ("timestamp")]
    public required long Timestamp { get; set; }
}