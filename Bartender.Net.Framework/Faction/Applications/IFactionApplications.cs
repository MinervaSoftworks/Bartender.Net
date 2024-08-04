namespace Bartender.Net.Framework.Faction.Applications;

public interface IFactionApplications {
    IDictionary<string, IFactionApplication> Applications { get; }
}