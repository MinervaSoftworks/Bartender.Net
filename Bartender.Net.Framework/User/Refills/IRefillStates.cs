namespace Bartender.Net.Framework.User.Refills;

public interface IRefillStates : IBartenderEntity {
    bool EnergyRefillUsed { get; set; }
    bool NerveRefillUsed { get; set; }
    int SpecialRefillsAvailable { get; set; }
    bool TokenRefillUsed { get; set; }
}