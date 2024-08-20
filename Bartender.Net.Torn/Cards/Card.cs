using Newtonsoft.Json;

namespace Bartender.Net.Torn.Cards;

public class Card {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("class")]
    public required string Class { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("rank")]
    public required int Rank { get; set; }

    [JsonProperty ("short")]
    public object Short { get; set; }
}
