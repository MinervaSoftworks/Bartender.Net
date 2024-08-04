namespace Bartender.Net.Framework.Faction.Applications;

public interface IFactionApplication : IBartenderEntity {
    int Expires { get; }
    int Level { get; }
    string Message { get; }
    string Name { get; }
    IFactionApplicationStats Stats { get; }
    string Status { get; }
    int UserID { get; }
}
