using Newtonsoft.Json;

namespace Bartender.Net.Torn.Bank;

public class InterestRates {
    [JsonProperty ("1w")]
    public double OneWeek { get; set; }

    [JsonProperty ("2w")]
    public double TwoWeeks { get; set; }

    [JsonProperty ("1m")]
    public double OneMonth { get; set; }

    [JsonProperty ("2m")]
    public double TwoMonths { get; set; }

    [JsonProperty ("3m")]
    public double ThreeMonths { get; set; }
}
