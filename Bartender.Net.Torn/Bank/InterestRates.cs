using Newtonsoft.Json;
using TornApi.Net.Models.Torn;

namespace Bartender.Net.Torn.Bank;

public class InterestRates : IInterestRates {
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
