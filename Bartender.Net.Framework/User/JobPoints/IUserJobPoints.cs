namespace Bartender.Net.Framework.User.JobPoints;

public interface IUserJobPoints : IBartenderEntity {
    int? Army { get; set; }
    int? Casino { get; set; }
    int? Education { get; set; }
    int? Grocer { get; set; }
    int? Law { get; set; }
    int? Medical { get; set; }
}