using Bartender.Net.Framework.User.Networth;
using Newtonsoft.Json;

namespace Bartender.Net.User.Networth;

public class NetworthRecord : INetworthRecord {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("pending")]
    public int Pending { get; set; }

    [JsonProperty ("wallet")]
    public int Wallet { get; set; }

    [JsonProperty ("bank")]
    public int Bank { get; set; }

    [JsonProperty ("points")]
    public int Points { get; set; }

    [JsonProperty ("cayman")]
    public int Cayman { get; set; }

    [JsonProperty ("vault")]
    public int Vault { get; set; }

    [JsonProperty ("piggybank")]
    public int Piggybank { get; set; }

    [JsonProperty ("items")]
    public int Items { get; set; }

    [JsonProperty ("displaycase")]
    public int Displaycase { get; set; }

    [JsonProperty ("bazaar")]
    public int Bazaar { get; set; }

    [JsonProperty ("trade")]
    public int Trade { get; set; }

    [JsonProperty ("itemmarket")]
    public int Itemmarket { get; set; }

    [JsonProperty ("properties")]
    public int Properties { get; set; }

    [JsonProperty ("stockmarket")]
    public int Stockmarket { get; set; }

    [JsonProperty ("auctionhouse")]
    public int Auctionhouse { get; set; }

    [JsonProperty ("company")]
    public int Company { get; set; }

    [JsonProperty ("bookie")]
    public int Bookie { get; set; }

    [JsonProperty ("enlistedcars")]
    public int Enlistedcars { get; set; }

    [JsonProperty ("loan")]
    public int Loan { get; set; }

    [JsonProperty ("unpaidfees")]
    public int Unpaidfees { get; set; }

    [JsonProperty ("total")]
    public int Total { get; set; }

    [JsonProperty ("parsetime")]
    public double Parsetime { get; set; }
}
