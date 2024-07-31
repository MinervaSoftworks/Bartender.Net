using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class FactionStub : IFactionStub {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("days_in_faction")]
    public int DaysInFaction { get; set; }

    [JsonProperty ("faction_id")]
    public int FactionID { get => ID; set => ID = value; }

    [JsonProperty ("faction_name")]
    public string FactionName { get; set; }

    [JsonProperty ("faction_tag")]
    public string FactionTag { get; set; }

    [JsonProperty ("position")]
    public string Position { get; set; }
}
