namespace Bartender.Net.Framework.User.Medals;

public interface IUserMedals : IBartenderEntity {
    IEnumerable<int> MedalsAwarded { get; }
    IEnumerable<int> MedalsTime { get; }
}