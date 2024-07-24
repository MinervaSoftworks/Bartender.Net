namespace Bartender.Net.Framework.User.JobPoints;

public interface ICompanyPointsCollection : IBartenderEntity {
    IDictionary<string, ICompanyPoints> CompanyPoints { get; set; }
}