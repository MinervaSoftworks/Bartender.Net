namespace Bartender.Net.Framework.User.Property;

public interface IPropertyModifications : IBartenderEntity {
    int Airstrip { get; set; }
    int HotTub { get; set; }
    int Interior { get; set; }
    int MedicalFacility { get; set; }
    int OpenBar { get; set; }
    int Pool { get; set; }
    int Sauna { get; set; }
    int ShootingRange { get; set; }
    int Vault { get; set; }
    int Yacht { get; set; }
}