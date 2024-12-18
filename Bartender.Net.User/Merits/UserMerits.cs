using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Merits;

public class UserMerits : BartenderEntity {
    [JsonProperty ("Nerve Bar")]
    public required int NerveBar { get; set; }

    [JsonProperty ("Critical Hit Rate")]
    public required int CriticalHitRate { get; set; }

    [JsonProperty ("Life Points")]
    public required int LifePoints { get; set; }

    [JsonProperty ("Crime XP")]
    public required int CrimeXP { get; set; }

    [JsonProperty ("Education Length")]
    public required int EducationLength { get; set; }

    [JsonProperty ("Awareness")]
    public required int Awareness { get; set; }

    [JsonProperty ("Bank Interest")]
    public required int BankInterest { get; set; }

    [JsonProperty ("Masterful Looting")]
    public required int MasterfulLooting { get; set; }

    [JsonProperty ("Stealth")]
    public required int Stealth { get; set; }

    [JsonProperty ("Hospitalizing")]
    public required int Hospitalizing { get; set; }

    [JsonProperty ("Addiction Mitigation")]
    public required int AddictionMitigation { get; set; }

    [JsonProperty ("Employee Effectiveness")]
    public required int EmployeeEffectiveness { get; set; }

    [JsonProperty ("Brawn")]
    public required int Brawn { get; set; }

    [JsonProperty ("Protection")]
    public required int Protection { get; set; }

    [JsonProperty ("Sharpness")]
    public required int Sharpness { get; set; }

    [JsonProperty ("Evasion")]
    public required int Evasion { get; set; }

    [JsonProperty ("Heavy Artillery Mastery")]
    public required int HeavyArtilleryMastery { get; set; }

    [JsonProperty ("Machine Gun Mastery")]
    public required int MachineGunMastery { get; set; }

    [JsonProperty ("Rifle Mastery")]
    public required int RifleMastery { get; set; }

    [JsonProperty ("SMG Mastery")]
    public required int SMGMastery { get; set; }

    [JsonProperty ("Shotgun Mastery")]
    public required int ShotgunMastery { get; set; }

    [JsonProperty ("Pistol Mastery")]
    public required int PistolMastery { get; set; }

    [JsonProperty ("Club Mastery")]
    public required int ClubMastery { get; set; }

    [JsonProperty ("Piercing Mastery")]
    public required int PiercingMastery { get; set; }

    [JsonProperty ("Slashing Mastery")]
    public required int SlashingMastery { get; set; }

    [JsonProperty ("Mechanical Mastery")]
    public required int MechanicalMastery { get; set; }

    [JsonProperty ("Temporary Mastery")]
    public required int TemporaryMastery { get; set; }
}
