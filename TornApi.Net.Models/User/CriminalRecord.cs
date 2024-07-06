using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class CriminalRecord {
    [JsonIgnore]
    public int ID { get; set; }
    
    [JsonProperty ("auto_theft")]
    public int AutoTheft { get; set; }

    [JsonProperty ("computer_crimes")]
    public int ComputerCrimes { get; set; }

    [JsonProperty("counterfeiting")]
    public int Counterfeiting { get; set; }

    [JsonProperty ("cybercrime")]
    public int Cybercrime { get; set; }

    [JsonProperty ("drug_deals")]
    public int DrugDeals { get; set; }

    [JsonProperty ("extortion")]
    public int Extortion { get; set; }

    [JsonProperty ("fraud")]
    public int Fraud { get; set; }

    [JsonProperty ("fraud_crimes")]
    public int FraudCrimes { get; set; }

    [JsonProperty ("illegalproduction")]
    public int IllegalProduction { get; set; }

    [JsonProperty ("illicitservices")]
    public int IllicitServices { get; set; }

    [JsonProperty ("murder")]
    public int Murder { get; set; }

    [JsonProperty ("other")]
    public int Other { get; set; }

    [JsonProperty ("selling_illegal_products")]
    public int SellingIllegalProducts { get; set; }

    [JsonProperty ("theft")]
    public int Theft { get; set; }

    [JsonProperty ("total")]
    public int Total { get; set; }

    [JsonProperty ("vandalism")]
    public int Vandalism { get; set; }
}
