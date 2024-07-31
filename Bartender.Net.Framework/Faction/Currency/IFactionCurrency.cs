namespace Bartender.Net.Framework.Faction.Currency {
    public interface IFactionCurrency {
        int FactionId { get; set; }
        int Money { get; set; }
        int Points { get; set; }
    }
}