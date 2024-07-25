namespace Bartender.Net.Framework.User.HoF; 

public interface IHallOfFame : IBartenderEntity {
    IHallOfFameRank Attacks { get; set; }
    IHallOfFameRank Awards { get; set; }
    IHallOfFameRank Battlestats { get; set; }
    IHallOfFameRank Busts { get; set; }
    IHallOfFameRank Defends { get; set; }
    IHallOfFameRank Level { get; set; }
    IHallOfFameRank Networth { get; set; }
    IHallOfFameRank Offences { get; set; }
    IHallOfFameRank Rank { get; set; }
    IHallOfFameRank Revives { get; set; }
    IHallOfFameRank Traveltime { get; set; }
    IHallOfFameRank Workstats { get; set; }
}