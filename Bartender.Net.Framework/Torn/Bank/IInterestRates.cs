namespace TornApi.Net.Models.Torn;

public interface IInterestRates {
    double OneMonth { get; }
    double OneWeek { get; }
    double ThreeMonths { get; }
    double TwoMonths { get; }
    double TwoWeeks { get; }
}
