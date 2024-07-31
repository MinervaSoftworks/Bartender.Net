namespace TornApi.Net.Models.Torn;

public interface IInterestRates {
    double OneMonth { get; set; }
    double OneWeek { get; set; }
    double ThreeMonths { get; set; }
    double TwoMonths { get; set; }
    double TwoWeeks { get; set; }
}
