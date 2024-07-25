namespace Bartender.Net.Framework.User.Missions;

public interface IMissionCollection : IBartenderEntity {
    List<IUserMission> Duke { get; set; }
}