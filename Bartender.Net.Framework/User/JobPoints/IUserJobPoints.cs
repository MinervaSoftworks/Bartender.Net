namespace Bartender.Net.Framework.User.JobPoints;

public interface IUserJobPoints : IBartenderEntity {
    int? Army { get; }
    int? Casino { get; }
    int? Education { get; }
    int? Grocer { get; }
    int? Law { get; }
    int? Medical { get; }
}