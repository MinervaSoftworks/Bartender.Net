using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class Status : IStatus {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("color")]
    public string Color { get; set; }

    [JsonIgnore]
    public StatusColor StatusColor {
        get => Color.ToStatusColor ();
        set => Color = value.ToStatusColorString ();
    }

    [JsonProperty ("description")]
    public string Description { get; set; }

    [JsonProperty ("details")]
    public string Details { get; set; }

    [JsonProperty ("state")]
    public string State { get; set; }

    [JsonIgnore]
    public StatusState StatusState {
        get => State.ToStatusState ();
        set => State = value.ToStatusStateString ();
    }

    [JsonProperty ("until")]
    public long Until { get; set; }
}

