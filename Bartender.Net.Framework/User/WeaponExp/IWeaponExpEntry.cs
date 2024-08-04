namespace Bartender.Net.Framework.User.WeaponExp;

public interface IWeaponExpEntry : IBartenderEntity {
    int Exp { get; }
    int ItemID { get; }
    string Name { get; }
}