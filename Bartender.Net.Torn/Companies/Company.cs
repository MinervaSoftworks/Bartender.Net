using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

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
    [NotMapped]
    public Dictionary<string, Position> Positions { get; set; } = default!;

    public virtual List<Position> PositionsList {
        get => Positions.TornDictionaryToList ();
        set => Positions = value.ToTornDictionary ();
    }

    [JsonProperty ("specials")]
    [NotMapped]
    public Dictionary<string, CompanySpecial> Specials { get; set; } = default!;

    public virtual List<CompanySpecial> SpecialsList {
        get => Specials.TornDictionaryToList ();
        set => Specials = value.ToTornDictionary ();
    }

    [JsonProperty ("stocks")]
    [NotMapped]
    public Dictionary<string, CompanyStock> Stocks { get; set; } = default!;

    public virtual List<CompanyStock> StocksList {
        get => Stocks.TornDictionaryToList ();
        set => Stocks = value.ToTornDictionary ();
    }
}

public class CompanyStock {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("cost")]
    public required int Cost { get; set; }

    [JsonProperty ("rrp")]
    public required int RRP { get; set; }
}
