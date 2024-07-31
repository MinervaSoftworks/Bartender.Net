namespace TornApi.Net.Models.Torn;

public interface IChainMemeber {
    int Assist { get; set; }
    int Attacks { get; set; }
    double Avg { get; set; }
    double Best { get; set; }
    int Bonus { get; set; }
    int Escape { get; set; }
    int FactionID { get; set; }
    int Hosp { get; set; }
    int Level { get; set; }
    int Leave { get; set; }
    int Loss { get; set; }
    int Mug { get; set; }
    int Overseas { get; set; }
    double Respect { get; set; }
    int Retal { get; set; }
    int War { get; set; }
    int UserID { get; set; }
}
