namespace Bartender.Net.Framework.User.Profile;

public interface IFactionStub : IBartenderEntity {
    int DaysInFaction { get; set; }
    int FactionID { get; set; }
    string FactionName { get; set; }
    string FactionTag { get; set; }
    string Position { get; set; }
}