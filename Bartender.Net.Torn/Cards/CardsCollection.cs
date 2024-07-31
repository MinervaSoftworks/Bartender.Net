using Bartender.Net.Torn.Bank;
using Newtonsoft.Json;

namespace Bartender.Net.Torn.Cards;

public class CardsCollection : ICardsCollection {
    [JsonProperty ("cards")]
    public Dictionary<int, ICard> Cards { get; set; }
}
