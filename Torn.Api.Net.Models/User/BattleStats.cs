namespace Torn.Api.Net.Models.User;

public class BattleStats {
    public int Defense { get; set; }

    public string[] DefenseInfo { get; set; }

    public int DefenseModifier { get; set; }

    public int Dexterity { get; set; }

    public string[] DexterityInfo { get; set; }

    public int DexterityModifier { get; set; }

    public int Speed { get; set; }

    public string[] SpeedInfo { get; set; }

    public int SpeedModifier { get; set; }

    public int Strength { get; set; }

    public string[] StrengthInfo { get; set; }

    public int StrengthModifier { get; set; }

    public int Total { get; set; }
}
