namespace Bartender.Net.Framework.User.Equipment;

public interface IUserEquipment : IBartenderEntity {
    int Equiped { get; }
    int MarketPrice { get; }
    string Name { get; }
    int Quantity { get; }
    string Type { get; }
    int UID { get; }
}