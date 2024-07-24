namespace Bartender.Net.Framework.User.HoF; 

public interface IHallOfFameRank : IBartenderEntity {
    int Rank { get; set; }
    int Value { get; set; }
}