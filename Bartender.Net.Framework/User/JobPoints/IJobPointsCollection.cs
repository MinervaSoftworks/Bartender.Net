namespace Bartender.Net.Framework.User.JobPoints;

public interface IJobPointsCollection {
    IUserJobPoints JobPoints { get; }
    IDictionary<string, ICompanyPoints> MyProperty { get; }
}