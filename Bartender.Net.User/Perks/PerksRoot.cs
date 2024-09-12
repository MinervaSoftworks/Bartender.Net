using Newtonsoft.Json;

namespace Bartender.Net.User.Perks;

public class PerksRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("faction_perks")]
    public required List<string> FactionPerks { get; set; }

    [JsonProperty ("job_perks")]
    public required List<string> JobPerks { get; set; }

    [JsonProperty ("property_perks")]
    public required List<string> PropertyPerks { get; set; }

    [JsonProperty ("education_perks")]
    public required List<string> EducationPerks { get; set; }

    [JsonProperty ("enhancer_perks")]
    public required List<string> EnhancerPerks { get; set; }

    [JsonProperty ("book_perks")]
    public required List<object> BookPerks { get; set; }

    [JsonProperty ("stock_perks")]
    public required List<string> StockPerks { get; set; }

    [JsonProperty ("merit_perks")]
    public required List<string> MeritPerks { get; set; }
}