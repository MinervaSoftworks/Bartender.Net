using Bartender.Net.Framework.User.Bars;

namespace Bartender.Net.Framework.User.Profile;

public interface IUserProfile : IBartenderEntity {
    int Age { get; }
    int Awards { get; }
    IDictionary<string, string> BasicIcons { get; }
    ICompetition Competition { get; }
    bool Donator { get; }
    int Enemies { get; }
    IFactionStub Faction { get; }
    int ForumPosts { get; }
    int Friends { get; }
    Gender Gender { get; }
    int Honor { get; }
    IJob Job { get; }
    int Karma { get; }
    ILastAction LastAction { get; }
    int Level { get; }
    IBar Life { get; }
    IMarriage Marriage { get; }
    string Name { get; }
    int ProfileID { get; }
    string Rank { get; }
    bool Revivable { get; }
    string Role { get; }
    string Signup { get; }
    IPlayerStates States { get; }
    IStatus Status { get; }
}