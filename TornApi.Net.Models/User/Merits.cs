using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Merits {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty("Nerve Bar")]
    public int NerveBar { get; set; }

    [JsonProperty("Critical Hit Rate")]
    public int CriticalHitRate { get; set; }

    [JsonProperty("Life Points")]
    public int LifePoints { get; set; }

    [JsonProperty("Crime XP")]
    public int CrimeXP { get; set; }

    [JsonProperty("Education Length")]
    public int EducationLength { get; set; }

    [JsonProperty("Awareness")]
    public int Awareness { get; set; }

    [JsonProperty("Bank Interest")]
    public int BankInterest { get; set; }

    [JsonProperty("Masterful Looting")]
    public int MasterfulLooting { get; set; }

    [JsonProperty("Stealth")]
    public int Stealth { get; set; }

    [JsonProperty("Hospitalizing")]
    public int Hospitalizing { get; set; }

    [JsonProperty("Addiction Mitigation")]
    public int AddictionMitigation { get; set; }

    [JsonProperty("Employee Effectiveness")]
    public int EmployeeEffectiveness { get; set; }

    [JsonProperty("Brawn")]
    public int Brawn { get; set; }

    [JsonProperty("Protection")]
    public int Protection { get; set; }

    [JsonProperty("Sharpness")]
    public int Sharpness { get; set; }

    [JsonProperty("Evasion")]
    public int Evasion { get; set; }

    [JsonProperty("Heavy Artillery Mastery")]
    public int HeavyArtilleryMastery { get; set; }

    [JsonProperty("Machine Gun Mastery")]
    public int MachineGunMastery { get; set; }

    [JsonProperty("Rifle Mastery")]
    public int RifleMastery { get; set; }

    [JsonProperty("SMG Mastery")]
    public int SMGMastery { get; set; }

    [JsonProperty("Shotgun Mastery")]
    public int ShotgunMastery { get; set; }

    [JsonProperty("Pistol Mastery")]
    public int PistolMastery { get; set; }

    [JsonProperty("Club Mastery")]
    public int ClubMastery { get; set; }

    [JsonProperty("Piercing Mastery")]
    public int PiercingMastery { get; set; }

    [JsonProperty("Slashing Mastery")]
    public int SlashingMastery { get; set; }

    [JsonProperty("Mechanical Mastery")]
    public int MechanicalMastery { get; set; }

    [JsonProperty("Temporary Mastery")]
    public int TemporaryMastery { get; set; }
}
