namespace Bartender.Net.Framework.Common.Armory;

public interface IFactionLoanable : IBartenderEntity
{
    int Available { get; set; }
    int Loaned { get; set; }
    string LoanedTo { get; set; }
    IEnumerable<int> LoanedToIDs { get; set; }
    string Name { get; set; }
    int Quantity { get; set; }
    string Type { get; set; }
}
