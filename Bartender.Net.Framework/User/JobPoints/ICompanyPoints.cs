namespace Bartender.Net.Framework.User.JobPoints; 

public interface ICompanyPoints : IBartenderEntity {
    int JobPoints { get; set; }
    string Name { get; set; }
}