using Bartender.Net.Framework.Company.Applications;

public interface ICompanyApplications {
    IDictionary<string, IApplication> Applications { get; }
}
