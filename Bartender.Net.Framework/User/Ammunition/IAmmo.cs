namespace Bartender.Net.Framework.User.Ammunition;

public interface IAmmo : IBartenderEntity {
    int AmmoID { get; }
    AmmoSize AmmoSize { get; }
    AmmoType AmmoType { get; }
    bool Equipped { get; }
    int Quantity { get; }
    string Size { get; }
    string Type { get; }
    int TypeID { get; }
}