namespace Bartender.Net.Framework.User.Networth;

public interface INetworthRecord : IBartenderEntity {
    int Auctionhouse { get; }
    int Bank { get; }
    int Bazaar { get; }
    int Bookie { get; }
    int Cayman { get; }
    int Company { get; }
    int Displaycase { get; }
    int Enlistedcars { get; }
    int Itemmarket { get; }
    int Items { get; }
    int Loan { get; }
    double Parsetime { get; }
    int Pending { get; }
    int Piggybank { get; }
    int Points { get; }
    int Properties { get; }
    int Stockmarket { get; }
    int Total { get; }
    int Trade { get; }
    int Unpaidfees { get; }
    int Vault { get; }
    int Wallet { get; }
}