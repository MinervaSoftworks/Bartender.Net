namespace Bartender.Net.Framework.Faction.Common;

public interface IFactionLoanable : IBartenderEntity {
    int Available { get; }
    int Loaned { get; }
    string LoanedTo { get; }
    IEnumerable<int> LoanedToIDs { get; }
    string Name { get; }
    int Quantity { get; }
    string Type { get; }
}
