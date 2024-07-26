namespace Bartender.Net.Framework.User.Profile;

public interface IPlayerStates : IBartenderEntity {
    long HospitalTimestamp { get; }
    long JailTimestamp { get; }
}