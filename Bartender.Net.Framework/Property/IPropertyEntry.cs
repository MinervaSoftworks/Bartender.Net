using Bartender.Net.Framework.Common.Property;

namespace Bartender.Net.Framework.Property;

public interface IPropertyEntry : IBartenderEntity {
    int Happy { get; }
    int OwnerId { get; }
    int PropertyType { get; }
    IRentEntry Rented { get; }
    List<string> Staff { get; }
    List<string> Upgrades { get; }
    int Upkeep { get; }
    string UsersLiving { get; }
}
