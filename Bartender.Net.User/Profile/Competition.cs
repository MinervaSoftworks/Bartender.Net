using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class Competition {
    public int ID { get; set; }

    [JsonProperty ("attacks")]
    public required int Attacks { get; set; }

    [JsonProperty ("image")]
    public required string Image { get; set; }

    [JsonProperty ("name")]
    public required string Name { 
        get => CompetitionTypeToNameString (CompetitionType);
        set => NameStringToCompetitionType (value);
    }

    public CompetitionType CompetitionType { get; set; }

    [JsonProperty ("position")]
    public required object Position { get; set; }

    [JsonProperty ("score")]
    public required float Score { get; set; }

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

    public static CompetitionType NameStringToCompetitionType (string competitionType) => competitionType switch {
        "Dog Tags" => CompetitionType.DogTags,
        "Easter Egg Hunt" => CompetitionType.EasterEggHunt,
        "Elimination" => CompetitionType.Elimination,
        "Halloween" => CompetitionType.Halloween,
        "Mr & Ms Torn" => CompetitionType.MrMsTorn,
        "Rock, Paper, Scissors" => CompetitionType.RockPaperScissors,
        _ => throw new ArgumentException ("Invalid competition type"),
    };

    public static string CompetitionTypeToNameString (CompetitionType competitionType) => competitionType switch {
        CompetitionType.DogTags => "Dog Tags",
        CompetitionType.EasterEggHunt => "Easter Egg Hunt",
        CompetitionType.Elimination => "Elimination",
        CompetitionType.Halloween => "Halloween",
        CompetitionType.MrMsTorn => "Mr & Ms Torn",
        CompetitionType.RockPaperScissors => "Rock, Paper, Scissors",
        _ => throw new ArgumentException ("Invalid CompetitionType value"),
    };

}
