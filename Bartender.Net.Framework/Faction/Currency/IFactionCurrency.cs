namespace Bartender.Net.Framework.Faction.Currency {
    public interface IFactionCurrency {
        int FactionId { get; }
        int Money { get; }
        int Points { get; }
    }
}