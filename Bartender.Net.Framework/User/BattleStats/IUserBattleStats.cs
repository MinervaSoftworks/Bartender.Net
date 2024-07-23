namespace Bartender.Net.Framework.User.BattleStats;

public interface IUserBattleStats : IBartenderEntity {
    long Defense { get; set; }
    IEnumerable<string> DefenseInfo { get; set; }
    int DefenseModifier { get; set; }
    long Dexterity { get; set; }
    IEnumerable<string> DexterityInfo { get; set; }
    int DexterityModifier { get; set; }
    long Speed { get; set; }
    IEnumerable<string> SpeedInfo { get; set; }
    int SpeedModifier { get; set; }
    long Strength { get; set; }
    IEnumerable<string> StrengthInfo { get; set; }
    int StrengthModifier { get; set; }
    long Total { get; set; }
}