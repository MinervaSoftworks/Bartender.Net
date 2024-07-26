namespace Bartender.Net.Framework.User.Profile;

public interface IFactionStub : IBartenderEntity {
    int DaysInFaction { get; }
    int FactionID { get; }
    string FactionName { get; }
    string FactionTag { get; }
    string Position { get; }
}