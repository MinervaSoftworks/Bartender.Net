using Newtonsoft.Json;

namespace Bartender.Net.User.CrimeRecord;

public class CrimnalRecordCollection {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("auto_theft")]
    public required int AutoTheft { get; set; }

    [JsonProperty ("computer_crimes")]
    public required int ComputerCrimes { get; set; }

    [JsonProperty ("counterfeiting")]
    public required int Counterfeiting { get; set; }

    [JsonProperty ("cybercrime")]
    public required int Cybercrime { get; set; }

    [JsonProperty ("drug_deals")]
    public required int DrugDeals { get; set; }

    [JsonProperty ("extortion")]
    public required int Extortion { get; set; }

    [JsonProperty ("fraud")]
    public required int Fraud { get; set; }

    [JsonProperty ("fraud_crimes")]
    public required int FraudCrimes { get; set; }

    [JsonProperty ("illegalproduction")]
    public required int IllegalProduction { get; set; }

    [JsonProperty ("illicitservices")]
    public required int IllicitServices { get; set; }

    [JsonProperty ("murder")]
    public required int Murder { get; set; }

    [JsonProperty ("other")]
    public required int Other { get; set; }

    [JsonProperty ("selling_illegal_products")]
    public required int SellingIllegalProducts { get; set; }

    [JsonProperty ("theft")]
    public required int Theft { get; set; }

    [JsonProperty ("total")]
    public required int Total { get; set; }

    [JsonProperty ("vandalism")]
    public required int Vandalism { get; set; }
}
