namespace Bartender.Net.Framework.User.Honors; 

public interface IUserHonors : IBartenderEntity {
    List<int> HonorsAwarded { get; set; }
    List<int> HonorsTime { get; set; }
    int ID { get; set; }
}