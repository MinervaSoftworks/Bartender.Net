namespace Bartender.Net.Framework.Faction.Common;

public interface IFactionLoanables {
    IEnumerable<IFactionLoanable> Loanables { get; }
}