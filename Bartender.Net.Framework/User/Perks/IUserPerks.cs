namespace Bartender.Net.Framework.User.Perks;

public interface IUserPerks : IBartenderEntity {
    List<object> BookPerks { get; set; }
    List<string> EducationPerks { get; set; }
    List<string> EnhancerPerks { get; set; }
    List<string> FactionPerks { get; set; }
    List<string> JobPerks { get; set; }
    List<string> MeritPerks { get; set; }
    List<string> PropertyPerks { get; set; }
    List<string> StockPerks { get; set; }
}