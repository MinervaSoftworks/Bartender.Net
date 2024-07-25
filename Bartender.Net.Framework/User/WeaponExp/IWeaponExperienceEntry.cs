namespace Bartender.Net.Framework.User.WeaponExp;

public interface IWeaponExperienceEntry : IBartenderEntity {
    int Exp { get; set; }
    int ItemID { get; set; }
    string Name { get; set; }
}