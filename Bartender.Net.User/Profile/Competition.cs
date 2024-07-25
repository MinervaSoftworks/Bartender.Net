using Bartender.Net.Framework.User.Profile;
using Bartender.Net.Extensions;
using Newtonsoft.Json;
using Bartender.Net.Extensions.User;

namespace Bartender.Net.User.Profile;

public class Competition : ICompetition {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("attacks")]
    public required int Attacks { get; set; }

    [JsonProperty ("image")]
    public required string Image { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    public CompetitionType CompetitionType { 
        get => Name.ToCompetitionType ();
        set => Name = value.ToCompetitionTypeString ();
    }

    [JsonProperty ("position")]
    public required object Position { get; set; }

    [JsonProperty ("score")]
    public required float Score { get; set; }

    [JsonProperty ("status")]
    public required string Status { get; set; }

    [JsonProperty ("team")]
    public required string Team { get; set; }

    [JsonProperty ("text")]
    public required string Text { get; set; }

    [JsonProperty ("total")]
    public required int Total { get; set; }

    [JsonProperty ("treats_collected_total")]
    public required int TreatsCollectedTotal { get; set; }

    [JsonProperty ("votes")]
    public required int Votes { get; set; }
}
