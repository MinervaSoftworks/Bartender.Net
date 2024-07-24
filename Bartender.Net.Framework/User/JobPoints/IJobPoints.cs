namespace Bartender.Net.Framework.User.JobPoints; 

public interface IJobPoints : IBartenderEntity {
    IJobPointsCollection Points { get; set; }
}