namespace Bartender.Net.Framework.User.Merits;

public interface IUserMerits : IBartenderEntity {
    int AddictionMitigation { get; set; }
    int Awareness { get; set; }
    int BankInterest { get; set; }
    int Brawn { get; set; }
    int ClubMastery { get; set; }
    int CrimeXP { get; set; }
    int CriticalHitRate { get; set; }
    int EducationLength { get; set; }
    int EmployeeEffectiveness { get; set; }
    int Evasion { get; set; }
    int HeavyArtilleryMastery { get; set; }
    int Hospitalizing { get; set; }
    int LifePoints { get; set; }
    int MachineGunMastery { get; set; }
    int MasterfulLooting { get; set; }
    int MechanicalMastery { get; set; }
    int NerveBar { get; set; }
    int PiercingMastery { get; set; }
    int PistolMastery { get; set; }
    int Protection { get; set; }
    int RifleMastery { get; set; }
    int Sharpness { get; set; }
    int ShotgunMastery { get; set; }
    int SlashingMastery { get; set; }
    int SMGMastery { get; set; }
    int Stealth { get; set; }
    int TemporaryMastery { get; set; }
}