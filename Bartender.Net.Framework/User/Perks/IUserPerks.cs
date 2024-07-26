namespace Bartender.Net.Framework.User.Perks;

public interface IUserPerks : IBartenderEntity {
    List<object> BookPerks { get; }
    List<string> EducationPerks { get; }
    List<string> EnhancerPerks { get; }
    List<string> FactionPerks { get; }
    List<string> JobPerks { get; }
    List<string> MeritPerks { get; }
    List<string> PropertyPerks { get; }
    List<string> StockPerks { get; }
}