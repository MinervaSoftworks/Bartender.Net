namespace Bartender.Net.Framework.User.Property;

public interface IPropertyStaff : IBartenderEntity {
    int Butler { get; set; }
    int Doctor { get; set; }
    int Guard { get; set; }
    int Maid { get; set; }
    int Pilot { get; set; }
}