namespace Bartender.Net.Framework.User.Honors;

public interface IUserHonors : IBartenderEntity {
    List<int> HonorsAwarded { get; }
    List<int> HonorsTime { get; }
}