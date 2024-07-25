namespace Bartender.Net.Framework.User.Property;

public interface IUserProperty : IBartenderEntity {
    int Cost { get; set; }
    int Happy { get; set; }
    int MarketPrice { get; set; }
    IPropertyModifications Modifications { get; set; }
    int OwnerId { get; set; }
    string PropertyName { get; set; }
    int PropertyType { get; set; }
    IRentEntry Rented { get; set; }
    IPropertyStaff Staff { get; set; }
    int StaffCost { get; set; }
    string Status { get; set; }
    int Upkeep { get; set; }
}