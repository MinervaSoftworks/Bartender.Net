using Newtonsoft.Json;

namespace Bartender.Net.User.Networth;

public class NetworthRecord {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("pending")]
    public required int Pending { get; set; }

    [JsonProperty ("wallet")]
    public required int Wallet { get; set; }

    [JsonProperty ("bank")]
    public required int Bank { get; set; }

    [JsonProperty ("points")]
    public required int Points { get; set; }

    [JsonProperty ("cayman")]
    public required int Cayman { get; set; }

    [JsonProperty ("vault")]
    public required int Vault { get; set; }

    [JsonProperty ("piggybank")]
    public required int Piggybank { get; set; }

    [JsonProperty ("items")]
    public required int Items { get; set; }

    [JsonProperty ("displaycase")]
    public required int Displaycase { get; set; }

    [JsonProperty ("bazaar")]
    public required int Bazaar { get; set; }

    [JsonProperty ("trade")]
    public required int Trade { get; set; }

    [JsonProperty ("itemmarket")]
    public required int Itemmarket { get; set; }

    [JsonProperty ("properties")]
    public required int Properties { get; set; }

    [JsonProperty ("stockmarket")]
    public required int Stockmarket { get; set; }

    [JsonProperty ("auctionhouse")]
    public required int Auctionhouse { get; set; }

    [JsonProperty ("company")]
    public required int Company { get; set; }

    [JsonProperty ("bookie")]
    public required int Bookie { get; set; }

    [JsonProperty ("enlistedcars")]
    public required int Enlistedcars { get; set; }

    [JsonProperty ("loan")]
    public required int Loan { get; set; }

    [JsonProperty ("unpaidfees")]
    public required int Unpaidfees { get; set; }

    [JsonProperty ("total")]
    public required int Total { get; set; }

    [JsonProperty ("parsetime")]
    public double Parsetime { get; set; }
}
