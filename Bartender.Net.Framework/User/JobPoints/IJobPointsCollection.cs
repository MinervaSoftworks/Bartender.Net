namespace Bartender.Net.Framework.User.JobPoints;

public interface IJobPointsCollection : IBartenderEntity {
    IUserJobPoints JobPoints { get; set; }
    IDictionary<string, ICompanyPoints> MyProperty { get; set; }
}