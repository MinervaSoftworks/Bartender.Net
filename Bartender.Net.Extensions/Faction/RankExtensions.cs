using Bartender.Net.Framework.Faction.Basic;

namespace Bartender.Net.Extensions.Faction;

public static class RankExtensions {
    public static string ToRankString (this Rank rank) => rank switch {
        Rank.Bronze => "Bronze",
        Rank.Diamond => "Diamond",
        Rank.Gold => "Gold",
        Rank.Platinum => "Platinum",
        Rank.Silver => "Silver",
        Rank.Unranked => "Unranked",
        _ => throw new Exception ("Unknown rank")
    };
}
