namespace Bartender.Net.Framework.User.BattleStats;

public interface IUserBattleStats : IBartenderEntity {
    long Defense { get; }
    IEnumerable<string> DefenseInfo { get; }
    int DefenseModifier { get; }
    long Dexterity { get; }
    IEnumerable<string> DexterityInfo { get; }
    int DexterityModifier { get; }
    long Speed { get; }
    IEnumerable<string> SpeedInfo { get; }
    int SpeedModifier { get; }
    long Strength { get; }
    IEnumerable<string> StrengthInfo { get; }
    int StrengthModifier { get; }
    long Total { get; }
}