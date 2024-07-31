namespace TornApi.Net.Models.Torn;

public interface IChainBonues {
    int Chain { get; set; }
    int Attacker { get; set; }
    int Defender { get; set; }
    int Respect { get; set; }
}
