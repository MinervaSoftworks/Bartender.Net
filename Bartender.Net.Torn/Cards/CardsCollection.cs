using Newtonsoft.Json;

namespace Bartender.Net.Torn.Cards;

public class CardsCollection {
    [JsonProperty ("cards")]
    public required Dictionary<int, Card> Cards { get; set; }
}
