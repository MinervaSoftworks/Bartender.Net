namespace Bartender.Net.Framework.Company.Applications;

public interface IApplication : IBartenderEntity {
    int Expires { get; }
    int Level { get; }
    string Message { get; }
    string Name { get; }
    IApplicationStats Stats { get; }
    string Status { get; }
    int UserID { get; }
}
