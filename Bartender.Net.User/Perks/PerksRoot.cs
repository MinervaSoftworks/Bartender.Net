using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Perks;

public class PerksRoot : BartenderEntity {
    [JsonProperty ("faction_perks")]
    public virtual required List<string> FactionPerks { get; set; }

    [JsonProperty ("job_perks")]
    public virtual required List<string> JobPerks { get; set; }

    [JsonProperty ("property_perks")]
    public virtual required List<string> PropertyPerks { get; set; }

    [JsonProperty ("education_perks")]
    public virtual required List<string> EducationPerks { get; set; }

    [JsonProperty ("enhancer_perks")]
    public virtual required List<string> EnhancerPerks { get; set; }

    [JsonProperty ("book_perks")]
    public virtual required List<string> BookPerks { get; set; }

    [JsonProperty ("stock_perks")]
    public virtual required List<string> StockPerks { get; set; }

    [JsonProperty ("merit_perks")]
    public virtual required List<string> MeritPerks { get; set; }
}