namespace Bartender.Net.Framework.User.Profile;

public interface ICompetition : IBartenderEntity {
    int Attacks { get; }
    CompetitionType CompetitionType { get; }
    string Image { get; }
    string Name { get; }
    object Position { get; }
    float Score { get; }
    // This is currently sending just the rock, paper, scissors status.
    // It's going to just be status anyway.
    string Status { get; }
    string Team { get; }
    string Text { get; }
    int Total { get; }
    int TreatsCollectedTotal { get; }
    int Votes { get; }
}