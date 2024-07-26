namespace Bartender.Net.Framework.User.WeaponExp;

public interface IWeaponExperienceEntry : IBartenderEntity {
    int Exp { get; }
    int ItemID { get; }
    string Name { get; }
}