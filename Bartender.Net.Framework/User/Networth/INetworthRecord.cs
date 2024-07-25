namespace Bartender.Net.Framework.User.Networth;

public interface INetworthRecord : IBartenderEntity {
    int Auctionhouse { get; set; }
    int Bank { get; set; }
    int Bazaar { get; set; }
    int Bookie { get; set; }
    int Cayman { get; set; }
    int Company { get; set; }
    int Displaycase { get; set; }
    int Enlistedcars { get; set; }
    int Itemmarket { get; set; }
    int Items { get; set; }
    int Loan { get; set; }
    double Parsetime { get; set; }
    int Pending { get; set; }
    int Piggybank { get; set; }
    int Points { get; set; }
    int Properties { get; set; }
    int Stockmarket { get; set; }
    int Total { get; set; }
    int Trade { get; set; }
    int Unpaidfees { get; set; }
    int Vault { get; set; }
    int Wallet { get; set; }
}