using Newtonsoft.Json;

namespace Bartender.Net.Torn.Cards;

public class Card {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("class")]
    public string Class { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("rank")]
    public int Rank { get; set; }

    [JsonProperty ("short")]
    public object Short { get; set; }
}
