using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Extensions.User;

public static class CompetitionTypeExtensions {
    public static string ToCompetitionTypeString (this CompetitionType competitionType) => competitionType switch {
        CompetitionType.DogTags => "Dog Tags",
        CompetitionType.EasterEggHunt => "Easter Egg Hunt",
        CompetitionType.Elimination => "Elimintaion",
        CompetitionType.Halloween => "Halloween",
        CompetitionType.MrMsTorn => "Mr & Ms Torn",
        CompetitionType.RockPaperScissors => "Rock, Paper, Scissors",
        _ => throw new Exception ("Unknown competition type")
    };
}
