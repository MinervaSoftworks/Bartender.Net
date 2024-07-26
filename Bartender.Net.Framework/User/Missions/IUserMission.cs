namespace Bartender.Net.Framework.User.Missions;

public interface IUserMission : IBartenderEntity {
    string Status { get; }
    string Title { get; }
}