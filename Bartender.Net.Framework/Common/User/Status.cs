using Bartender.Net.Framework.Extensions;
using Bartender.Net.Framework.Extensions.User;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.User;

public class Status : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("color")]
    public required string Color { get; set; }

    [JsonIgnore]
    public StatusColor StatusColor {
        get => Color.ToStatusColor ();
        set => Color = value.ToStatusColorString ();
    }

    [JsonProperty ("description")]
    public required string Description { get; set; }

    [JsonProperty ("details")]
    public required string Details { get; set; }

    [JsonProperty ("state")]
    public required string State { get; set; }

    [JsonIgnore]
    public StatusState StatusState {
        get => State.ToStatusState ();
        set => State = value.ToStatusStateString ();
    }

    [JsonProperty ("until")]
    public required long Until { get; set; }
}

