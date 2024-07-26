namespace Bartender.Net.Framework.Company.Detailed;

public interface ICompanyUpgrades : IBartenderEntity {
    int CompanySize { get; }
    string StaffroomSize { get; }
    string StorageSize { get; }
    int StorageSpace { get; }
}