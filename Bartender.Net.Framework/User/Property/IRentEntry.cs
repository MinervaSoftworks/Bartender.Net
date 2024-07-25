namespace Bartender.Net.Framework.User.Property;

public interface IRentEntry : IBartenderEntity {
    int CostPerDay { get; set; }
    int DaysLeft { get; set; }
    int TotalCost { get; set; }
    int UserID { get; set; }
}