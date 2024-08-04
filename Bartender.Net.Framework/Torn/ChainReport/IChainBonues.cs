namespace TornApi.Net.Models.Torn;

public interface IChainBonues {
    int Chain { get; }
    int Attacker { get; }
    int Defender { get; }
    int Respect { get; }
}
