namespace Bartender.Net.Framework.Common.Property;

public interface IRentEntry : IBartenderEntity
{
    int CostPerDay { get; }
    int DaysLeft { get; }
    int TotalCost { get; }
    int UserID { get; }
}