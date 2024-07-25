namespace Bartender.Net.Framework.User.Profile;

public interface ICompetition : IBartenderEntity {
    int Attacks { get; set; }
    CompetitionType CompetitionType { get; set; }
    string Image { get; set; }
    string Name { get; set; }
    object Position { get; set; }
    float Score { get; set; }
    // This is currently sending just the rock, paper, scissors status.
    // It's going to just be status anyway.
    string Status { get; set; }
    string Team { get; set; }
    string Text { get; set; }
    int Total { get; set; }
    int TreatsCollectedTotal { get; set; }
    int Votes { get; set; }
}