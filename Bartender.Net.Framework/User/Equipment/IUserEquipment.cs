namespace Bartender.Net.Framework.User.Equipment;

public interface IUserEquipment : IBartenderEntity {
    int Equiped { get; set; }
    int MarketPrice { get; set; }
    string Name { get; set; }
    int Quantity { get; set; }
    string Type { get; set; }
    int UID { get; set; }
}