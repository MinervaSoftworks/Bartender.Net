namespace Bartender.Net.Framework.User.Property;

public interface IPropertyModifications : IBartenderEntity {
    int Airstrip { get; }
    int HotTub { get; }
    int Interior { get; }
    int MedicalFacility { get; }
    int OpenBar { get; }
    int Pool { get; }
    int Sauna { get; }
    int ShootingRange { get; }
    int Vault { get; }
    int Yacht { get; }
}