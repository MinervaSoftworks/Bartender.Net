namespace Bartender.Net.Framework.User.Refills;

public interface IRefillStates : IBartenderEntity {
    bool EnergyRefillUsed { get; }
    bool NerveRefillUsed { get; }
    int SpecialRefillsAvailable { get; }
    bool TokenRefillUsed { get; }
}