namespace Bartender.Net.Framework.Faction.Applications;

public interface IFactionApplicationStats : IBartenderEntity {
    int Defense { get; }
    int Dexterity { get; }
    int Speed { get; }
    int Strength { get; }
}
