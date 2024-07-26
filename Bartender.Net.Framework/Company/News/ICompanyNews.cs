namespace Bartender.Net.Framework.Company.News;

public interface ICompanyNews {
    IDictionary<string, ICompanyNewsEntry> MyProperty { get; set; }
}
