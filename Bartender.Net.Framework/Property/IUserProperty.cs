using Bartender.Net.Framework;

public interface IUserProperty : IBartenderEntity {
    int Happy { get; }
    int OwnerId { get; }
    int PropertyType { get; }
    object Rented { get; }
    List<string> Staff { get; }
    List<string> Upgrades { get; }
    int Upkeep { get; }
    string UsersLiving { get; }
}