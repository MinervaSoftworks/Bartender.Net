using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.Faction.Crimes;

public interface IFactionCrime : IBartenderEntity {
    int CrimeType { get; }
    bool Initiated { get; }
    int InitiatedBy { get; }
    int MoneyGain { get; }
    string Name { get; }
    IDictionary<string, IStatus> Participants { get; }
    int PlannedBy { get; }
    int RespectGain { get; }
    bool Success { get; }
    long TimeComplete { get; }
    int TimeLeft { get; }
    long TimeReady { get; }
    long TimeStarted { get; }
}
