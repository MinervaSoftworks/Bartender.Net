namespace Bartender.Net.Framework.User.Property;

public interface IPropertyStaff : IBartenderEntity {
    int Butler { get; }
    int Doctor { get; }
    int Guard { get; }
    int Maid { get; }
    int Pilot { get; }
}