using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class Competition : ICompetition {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("attacks")]
    public int Attacks { get; set; }

    [JsonProperty ("image")]
    public string Image { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    public CompetitionType CompetitionType {
        get => Name.ToCompetitionType ();
        set => Name = value.ToCompetitionTypeString ();
    }

    [JsonProperty ("position")]
    public object Position { get; set; }

    [JsonProperty ("score")]
    public float Score { get; set; }

    [JsonProperty ("status")]
    public string Status { get; set; }

    [JsonProperty ("team")]
    public string Team { get; set; }

    [JsonProperty ("text")]
    public string Text { get; set; }

    [JsonProperty ("total")]
    public int Total { get; set; }

    [JsonProperty ("treats_collected_total")]
    public int TreatsCollectedTotal { get; set; }

    [JsonProperty ("votes")]
    public int Votes { get; set; }
}
