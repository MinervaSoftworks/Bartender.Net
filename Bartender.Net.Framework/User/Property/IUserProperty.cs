using Bartender.Net.Framework.Common.Property;

namespace Bartender.Net.Framework.User.Property;

public interface IUserProperty : IBartenderEntity {
    int Cost { get; }
    int Happy { get; }
    int MarketPrice { get; }
    IPropertyModifications Modifications { get; }
    int OwnerId { get; }
    string PropertyName { get; }
    int PropertyType { get; }
    IRentEntry Rented { get; }
    IPropertyStaff Staff { get; }
    int StaffCost { get; }
    string Status { get; }
    int Upkeep { get; }
}