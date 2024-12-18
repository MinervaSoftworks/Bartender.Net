using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Bartender.Net.Framework.Extensions.User;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Profile;

public class Competition : BartenderEntity {
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
    [NotMapped]
    // TODO This needs to be figured out and turned into it's own class
    // Hesitant to do so b/c idk if it's going to change or not
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
