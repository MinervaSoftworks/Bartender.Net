using Newtonsoft.Json;

namespace Bartender.Net.Torn.Companies;

public class Company {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("cost")]
    public required int Cost { get; set; }

    [JsonProperty ("default_employess")]
    public required int DefaultEmployess { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("position")]
    public required Dictionary<string, Position> Positions { get; set; }

    [JsonProperty ("specials")]
    public required Dictionary<string, CompanySpecial> Specials { get; set; }

    [JsonProperty ("stocks")]
    public required Dictionary<string, CompanyStock> Stocks { get; set; }
}

public class CompanyStock {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("cost")]
    public required int Cost { get; set; }

    [JsonProperty ("rrp")]
    public required int RRP { get; set; }
}
