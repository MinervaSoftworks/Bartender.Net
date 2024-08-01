using Bartender.Net.Framework.Common.Property;

namespace Bartender.Net.Framework.Property;

public interface IPropertyEntry : IBartenderEntity {
    int Happy { get; set; }
    int OwnerId { get; set; }
    int PropertyType { get; set; }
    IRentEntry Rented { get; set; }
    List<string> Staff { get; set; }
    List<string> Upgrades { get; set; }
    int Upkeep { get; set; }
    string UsersLiving { get; set; }
}
