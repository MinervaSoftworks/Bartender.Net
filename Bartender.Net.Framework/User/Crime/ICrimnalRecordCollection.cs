namespace Bartender.Net.Framework.User.Crime;

public interface ICrimnalRecordCollection : IBartenderEntity {
    int AutoTheft { get; set; }
    int ComputerCrimes { get; set; }
    int Counterfeiting { get; set; }
    int Cybercrime { get; set; }
    int DrugDeals { get; set; }
    int Extortion { get; set; }
    int Fraud { get; set; }
    int FraudCrimes { get; set; }
    int IllegalProduction { get; set; }
    int IllicitServices { get; set; }
    int Murder { get; set; }
    int Other { get; set; }
    int SellingIllegalProducts { get; set; }
    int Theft { get; set; }
    int Total { get; set; }
    int Vandalism { get; set; }
}