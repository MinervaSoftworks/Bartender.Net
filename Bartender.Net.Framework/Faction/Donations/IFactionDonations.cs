namespace Bartender.Net.Framework.Faction.Donations;

public interface IFactionDonations {
    IDictionary<string, IDonationEntry> Donations { get; set; }
}
