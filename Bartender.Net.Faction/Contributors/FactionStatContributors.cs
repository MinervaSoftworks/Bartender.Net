using Newtonsoft.Json;

namespace Bartender.Net.Faction.Contributors;

public class FactionStatContributors {
    [JsonProperty ("medicalitemsused")]
    public List<FactionStatContributor> MedicalItemsUsed { get; set; }

    [JsonProperty ("criminaloffences")]
    public List<FactionStatContributor> CriminalOffences { get; set; }

    [JsonProperty ("organisedcrimerespect")]
    public List<FactionStatContributor> OrganisedCrimeRespect { get; set; }

    [JsonProperty ("organisedcrimemoney")]
    public List<FactionStatContributor> OrganisedCrimeMoney { get; set; }

    [JsonProperty ("organisedcrimesuccess")]
    public List<FactionStatContributor> OrganisedCrimeSuccess { get; set; }

    [JsonProperty ("organisedcrimefail")]
    public List<FactionStatContributor> OrganisedCrimeFail { get; set; }

    [JsonProperty ("attackswon")]
    public List<FactionStatContributor> AttacksWon { get; set; }

    [JsonProperty ("attackslost")]
    public List<FactionStatContributor> AttacksLost { get; set; }

    [JsonProperty ("attackschain")]
    public List<FactionStatContributor> AttacksChain { get; set; }

    [JsonProperty ("attacksleave")]
    public List<FactionStatContributor> AttacksLeave { get; set; }

    [JsonProperty ("attacksmug")]
    public List<FactionStatContributor> AttacksMug { get; set; }

    [JsonProperty ("attackshosp")]
    public List<FactionStatContributor> AttacksHosp { get; set; }

    [JsonProperty ("bestchain")]
    public List<FactionStatContributor> BestChain { get; set; }

    [JsonProperty ("busts")]
    public List<FactionStatContributor> Busts { get; set; }

    [JsonProperty ("revives")]
    public List<FactionStatContributor> Revives { get; set; }

    [JsonProperty ("jails")]
    public List<FactionStatContributor> Jails { get; set; }

    [JsonProperty ("hosps")]
    public List<FactionStatContributor> Hosps { get; set; }

    [JsonProperty ("medicalitemrecovery")]
    public List<FactionStatContributor> MedicalItemRecovery { get; set; }

    [JsonProperty ("medicalcooldownused")]
    public List<FactionStatContributor> MedicalCooldownUsed { get; set; }

    [JsonProperty ("gymtrains")]
    public List<FactionStatContributor> GymTrains { get; set; }

    [JsonProperty ("gymstrength")]
    public List<FactionStatContributor> GymStrength { get; set; }

    [JsonProperty ("gymspeed")]
    public List<FactionStatContributor> GymSpeed { get; set; }

    [JsonProperty ("gymdefense")]
    public List<FactionStatContributor> GymDefense { get; set; }

    [JsonProperty ("gymdexterity")]
    public List<FactionStatContributor> GymDexterity { get; set; }

    [JsonProperty ("candyused")]
    public List<FactionStatContributor> CandyUsed { get; set; }

    [JsonProperty ("alcoholused")]
    public List<FactionStatContributor> AlcoholUsed { get; set; }

    [JsonProperty ("energydrinkused")]
    public List<FactionStatContributor> EnergyDrinkUsed { get; set; }

    [JsonProperty ("drugsused")]
    public List<FactionStatContributor> DrugsUsed { get; set; }

    [JsonProperty ("drugoverdoses")]
    public List<FactionStatContributor> DrugOverdoses { get; set; }

    [JsonProperty ("rehabs")]
    public List<FactionStatContributor> Rehabs { get; set; }

    [JsonProperty ("caymaninterest")]
    public List<FactionStatContributor> CaymanInterest { get; set; }

    [JsonProperty ("traveltimes")]
    public List<FactionStatContributor> TravelTimes { get; set; }

    [JsonProperty ("traveltime")]
    public List<FactionStatContributor> TravelTime { get; set; }

    [JsonProperty ("hunting")]
    public List<FactionStatContributor> Hunting { get; set; }

    [JsonProperty ("attacksdamagehits")]
    public List<FactionStatContributor> AttacksDamageHits { get; set; }

    [JsonProperty ("attacksdamage")]
    public List<FactionStatContributor> AttacksDamage { get; set; }

    [JsonProperty ("hosptimegiven")]
    public List<FactionStatContributor> HospTimeGiven { get; set; }

    [JsonProperty ("hosptimereceived")]
    public List<FactionStatContributor> HospTimeReceived { get; set; }

    [JsonProperty ("attacksdamaging")]
    public List<FactionStatContributor> AttacksDamaging { get; set; }

    [JsonProperty ("attacksrunaway")]
    public List<FactionStatContributor> AttacksRunaway { get; set; }

    [JsonProperty ("highestterritories")]
    public List<FactionStatContributor> HighestTerritories { get; set; }

    [JsonProperty ("territoryrespect")]
    public List<FactionStatContributor> TerritoryRespect { get; set; }
}
