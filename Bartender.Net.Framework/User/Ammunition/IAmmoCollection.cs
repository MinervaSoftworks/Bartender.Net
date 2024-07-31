namespace Bartender.Net.Framework.User.Ammunition;

public interface IAmmoCollection {
    IEnumerable<IAmmo> Ammo { get; }
}