namespace Bartender.Net.Framework.User.Merits;

public interface IUserMerits : IBartenderEntity {
    int AddictionMitigation { get; }
    int Awareness { get; }
    int BankInterest { get; }
    int Brawn { get; }
    int ClubMastery { get; }
    int CrimeXP { get; }
    int CriticalHitRate { get; }
    int EducationLength { get; }
    int EmployeeEffectiveness { get; }
    int Evasion { get; }
    int HeavyArtilleryMastery { get; }
    int Hospitalizing { get; }
    int LifePoints { get; }
    int MachineGunMastery { get; }
    int MasterfulLooting { get; }
    int MechanicalMastery { get; }
    int NerveBar { get; }
    int PiercingMastery { get; }
    int PistolMastery { get; }
    int Protection { get; }
    int RifleMastery { get; }
    int Sharpness { get; }
    int ShotgunMastery { get; }
    int SlashingMastery { get; }
    int SMGMastery { get; }
    int Stealth { get; }
    int TemporaryMastery { get; }
}