namespace Bartender.Net.Framework.Common.Armory;

public interface IFactionLoanables
{
    IEnumerable<IFactionLoanable> Loanables { get; }
}