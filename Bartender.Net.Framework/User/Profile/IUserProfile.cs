using Bartender.Net.Framework.User.Bars;

namespace Bartender.Net.Framework.User.Profile;

public interface IUserProfile : IBartenderEntity {
    int Age { get; set; }
    int Awards { get; set; }
    IDictionary<string, string> BasicIcons { get; set; }
    ICompetition Competition { get; set; }
    bool Donator { get; set; }
    int Enemies { get; set; }
    IFactionStub Faction { get; set; }
    int ForumPosts { get; set; }
    int Friends { get; set; }
    Gender Gender { get; set; }
    int Honor { get; set; }
    IJob Job { get; set; }
    int Karma { get; set; }
    ILastAction LastAction { get; set; }
    int Level { get; set; }
    IBar Life { get; set; }
    IMarriage Marriage { get; set; }
    string Name { get; set; }
    int ProfileID { get; set; }
    string Rank { get; set; }
    bool Revivable { get; set; }
    string Role { get; set; }
    string Signup { get; set; }
    IPlayerStates States { get; set; }
    IStatus Status { get; set; }
}