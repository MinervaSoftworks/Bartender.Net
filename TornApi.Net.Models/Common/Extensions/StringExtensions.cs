using TornApi.Net.Models.Faction;

namespace TornApi.Net.Models.Common.Extensions {
    public static partial class StringExtensions {
        public static LastActionStatus ToLastActionStatus (this string status) => status switch {
            "Idle" => LastActionStatus.Idle,
            "Offline" => LastActionStatus.Offline,
            "Online" => LastActionStatus.Online,
            _ => throw new Exception ($"Unknown LastActionStatus {status}")
        };

        public static StatusColor ToStatusColor (this string color) => color switch {
            "red" => StatusColor.Red,
            "green" => StatusColor.Green,
            "blue" => StatusColor.Blue,
            _ => throw new Exception($"Unknown StatusColor {color}")
        };

        public static StatusState ToStatusState (this string state) => state switch {
            "Abroad" => StatusState.Abroad,
            "Fallen" => StatusState.Fallen,
            "Federal" => StatusState.Federal,
            "Hospital" => StatusState.Hospital,
            "Jail" => StatusState.Jail,
            "Okay" => StatusState.Okay,
            "Traveling" => StatusState.Traveling,
            _ => throw new Exception ($"Unknow StatusState {state}")
        };

        public static Rank ToRank (this string rank) => rank switch {
            "Bronze" => Rank.Bronze,
            "Diamond" => Rank.Diamond,
            "Gold" => Rank.Gold,
            "Platinum" => Rank.Platinum,
            "Silver" => Rank.Silver,
            "Unranked" => Rank.Unranked,
            _ => throw new Exception ($"Unknown Rank {rank}")
        };
    }
}
