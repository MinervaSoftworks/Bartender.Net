namespace Bartender.Net.Framework.Faction.Applications;

public interface IFactionApplication : IBartenderEntity {
    int Expires { get; set; }
    int Level { get; set; }
    string Message { get; set; }
    string Name { get; set; }
    IFactionApplicationStats Stats { get; set; }
    string Status { get; set; }
    int UserID { get; set; }
}
