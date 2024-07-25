namespace Bartender.Net.Framework.User.Medals; 

public interface IUserMedals : IBartenderEntity {
    IEnumerable<int> MedalsAwarded { get; set; }
    IEnumerable<int> MedalsTime { get; set; }
}