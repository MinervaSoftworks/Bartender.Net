using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.Faction.Crimes;

public interface IFactionCrime : IBartenderEntity {
    int CrimeType { get; set; }
    bool Initiated { get; set; }
    int InitiatedBy { get; set; }
    int MoneyGain { get; set; }
    string Name { get; set; }
    IDictionary<string, IStatus> Participants { get; set; }
    int PlannedBy { get; set; }
    int RespectGain { get; set; }
    bool Success { get; set; }
    long TimeComplete { get; set; }
    int TimeLeft { get; set; }
    long TimeReady { get; set; }
    long TimeStarted { get; set; }
}
