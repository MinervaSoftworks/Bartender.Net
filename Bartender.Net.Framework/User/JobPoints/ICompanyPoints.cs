namespace Bartender.Net.Framework.User.JobPoints;

public interface ICompanyPoints : IBartenderEntity {
    int JobPoints { get; }
    string Name { get; }
}