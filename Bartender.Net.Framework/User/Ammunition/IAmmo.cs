namespace Bartender.Net.Framework.User.Ammunition;

public interface IAmmo : IBartenderEntity {
    int AmmoID { get; set; }
    AmmoSize AmmoSize { get; set; }
    AmmoType AmmoType { get; set; }
    bool Equipped { get; set; }
    int Quantity { get; set; }
    string Size { get; set; }
    string Type { get; set; }
    int TypeID { get; set; }
}