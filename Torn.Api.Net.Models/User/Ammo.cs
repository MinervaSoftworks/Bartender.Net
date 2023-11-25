namespace Torn.Api.Net.Models.User;

public class Ammo {
    public int AmmoId { get; set; }

    public int Equipped { get; set; }

    public int Quantity { get; set; }

    public AmmoSize Size { get; set; }

    public AmmoType Type { get; set; }

    public int TypeID { get; set; }
}
