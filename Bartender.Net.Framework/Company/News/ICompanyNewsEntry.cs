namespace Bartender.Net.Framework.Company.News;

public interface ICompanyNewsEntry : IBartenderEntity {
    string News { get; }
    int Timestamp { get; }
}
