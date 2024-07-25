namespace Bartender.Net.Framework.User.JobPoints;

public interface IJobPointsCollection {
    IUserJobPoints JobPoints { get; set; }
    IDictionary<string, ICompanyPoints> MyProperty { get; set; }
}