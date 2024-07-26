namespace Bartender.Net.Framework.User.HoF; 

public interface IHallOfFame : IBartenderEntity {
    IHallOfFameRank Attacks { get; }
    IHallOfFameRank Awards { get; }
    IHallOfFameRank Battlestats { get; }
    IHallOfFameRank Busts { get; }
    IHallOfFameRank Defends { get; }
    IHallOfFameRank Level { get; }
    IHallOfFameRank Networth { get; }
    IHallOfFameRank Offences { get; }
    IHallOfFameRank Rank { get; }
    IHallOfFameRank Revives { get; }
    IHallOfFameRank Traveltime { get; }
    IHallOfFameRank Workstats { get; }
}