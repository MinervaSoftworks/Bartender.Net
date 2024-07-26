namespace Bartender.Net.Framework.User.HoF; 

public interface IHallOfFameRank : IBartenderEntity {
    int Rank { get; }
    int Value { get; }
}