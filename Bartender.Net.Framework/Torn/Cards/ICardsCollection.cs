namespace Bartender.Net.Torn.Bank;

public interface ICardsCollection {
    Dictionary<int, ICard> Cards { get; set; }
}
