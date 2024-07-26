namespace Bartender.Net.Framework.User.Crime;

public interface ICrimnalRecordCollection : IBartenderEntity {
    int AutoTheft { get; }
    int ComputerCrimes { get; }
    int Counterfeiting { get; }
    int Cybercrime { get; }
    int DrugDeals { get; }
    int Extortion { get; }
    int Fraud { get; }
    int FraudCrimes { get; }
    int IllegalProduction { get; }
    int IllicitServices { get; }
    int Murder { get; }
    int Other { get; }
    int SellingIllegalProducts { get; }
    int Theft { get; }
    int Total { get; }
    int Vandalism { get; }
}