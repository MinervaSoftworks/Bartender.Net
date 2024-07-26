namespace Bartender.Net.Framework.Company.Companies;

public interface ICompanyEntries {
    IDictionary<string, ICompanyEntry> Companies { get; }
}