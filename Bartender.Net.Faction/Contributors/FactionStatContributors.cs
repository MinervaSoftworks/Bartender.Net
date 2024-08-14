using Newtonsoft.Json;

namespace Bartender.Net.Faction.Contributors;

public class FactionStatContributors {
    [JsonProperty ("medicalitemsused")]
    public required List<FactionStatContributor> MedicalItemsUsed { get; set; }

    [JsonProperty ("criminaloffences")]
    public required List<FactionStatContributor> CriminalOffences { get; set; }

    [JsonProperty ("organisedcrimerespect")]
    public required List<FactionStatContributor> OrganisedCrimeRespect { get; set; }

    [JsonProperty ("organisedcrimemoney")]
    public required List<FactionStatContributor> OrganisedCrimeMoney { get; set; }

    [JsonProperty ("organisedcrimesuccess")]
    public required List<FactionStatContributor> OrganisedCrimeSuccess { get; set; }

    [JsonProperty ("organisedcrimefail")]
    public required List<FactionStatContributor> OrganisedCrimeFail { get; set; }

    [JsonProperty ("attackswon")]
    public required List<FactionStatContributor> AttacksWon { get; set; }

    [JsonProperty ("attackslost")]
    public required List<FactionStatContributor> AttacksLost { get; set; }

    [JsonProperty ("attackschain")]
    public required List<FactionStatContributor> AttacksChain { get; set; }

    [JsonProperty ("attacksleave")]
    public required List<FactionStatContributor> AttacksLeave { get; set; }

    [JsonProperty ("attacksmug")]
    public required List<FactionStatContributor> AttacksMug { get; set; }

    [JsonProperty ("attackshosp")]
    public required List<FactionStatContributor> AttacksHosp { get; set; }

    [JsonProperty ("bestchain")]
    public required List<FactionStatContributor> BestChain { get; set; }

    [JsonProperty ("busts")]
    public required List<FactionStatContributor> Busts { get; set; }

    [JsonProperty ("revives")]
    public required List<FactionStatContributor> Revives { get; set; }

    [JsonProperty ("jails")]
    public required List<FactionStatContributor> Jails { get; set; }

    [JsonProperty ("hosps")]
    public required List<FactionStatContributor> Hosps { get; set; }

    [JsonProperty ("medicalitemrecovery")]
    public required List<FactionStatContributor> MedicalItemRecovery { get; set; }

    [JsonProperty ("medicalcooldownused")]
    public required List<FactionStatContributor> MedicalCooldownUsed { get; set; }

    [JsonProperty ("gymtrains")]
    public required List<FactionStatContributor> GymTrains { get; set; }

    [JsonProperty ("gymstrength")]
    public required List<FactionStatContributor> GymStrength { get; set; }

    [JsonProperty ("gymspeed")]
    public required List<FactionStatContributor> GymSpeed { get; set; }

    [JsonProperty ("gymdefense")]
    public required List<FactionStatContributor> GymDefense { get; set; }

    [JsonProperty ("gymdexterity")]
    public required List<FactionStatContributor> GymDexterity { get; set; }

    [JsonProperty ("candyused")]
    public required List<FactionStatContributor> CandyUsed { get; set; }

    [JsonProperty ("alcoholused")]
    public required List<FactionStatContributor> AlcoholUsed { get; set; }

    [JsonProperty ("energydrinkused")]
    public required List<FactionStatContributor> EnergyDrinkUsed { get; set; }

    [JsonProperty ("drugsused")]
    public required List<FactionStatContributor> DrugsUsed { get; set; }

    [JsonProperty ("drugoverdoses")]
    public required List<FactionStatContributor> DrugOverdoses { get; set; }

    [JsonProperty ("rehabs")]
    public required List<FactionStatContributor> Rehabs { get; set; }

    [JsonProperty ("caymaninterest")]
    public required List<FactionStatContributor> CaymanInterest { get; set; }

    [JsonProperty ("traveltimes")]
    public required List<FactionStatContributor> TravelTimes { get; set; }

    [JsonProperty ("traveltime")]
    public required List<FactionStatContributor> TravelTime { get; set; }

    [JsonProperty ("hunting")]
    public required List<FactionStatContributor> Hunting { get; set; }

    [JsonProperty ("attacksdamagehits")]
    public required List<FactionStatContributor> AttacksDamageHits { get; set; }

    [JsonProperty ("attacksdamage")]
    public required List<FactionStatContributor> AttacksDamage { get; set; }

    [JsonProperty ("hosptimegiven")]
    public required List<FactionStatContributor> HospTimeGiven { get; set; }

    [JsonProperty ("hosptimereceived")]
    public required List<FactionStatContributor> HospTimeReceived { get; set; }

    [JsonProperty ("attacksdamaging")]
    public required List<FactionStatContributor> AttacksDamaging { get; set; }

    [JsonProperty ("attacksrunaway")]
    public required List<FactionStatContributor> AttacksRunaway { get; set; }

    [JsonProperty ("highestterritories")]
    public required List<FactionStatContributor> HighestTerritories { get; set; }

    [JsonProperty ("territoryrespect")]
    public required List<FactionStatContributor> TerritoryRespect { get; set; }
}
