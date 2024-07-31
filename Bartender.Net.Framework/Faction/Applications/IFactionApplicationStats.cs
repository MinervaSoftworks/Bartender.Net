namespace Bartender.Net.Framework.Faction.Applications;

public interface IFactionApplicationStats : IBartenderEntity {
    int Defense { get; set; }
    int Dexterity { get; set; }
    int Speed { get; set; }
    int Strength { get; set; }
}
