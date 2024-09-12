using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Contributors;

public class StatContributors : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("medicalitemsused")]
    public required List<MemberContributor> MedicalItemsUsed { get; set; }

    [JsonProperty ("criminaloffences")]
    public required List<MemberContributor> CriminalOffences { get; set; }

    [JsonProperty ("organisedcrimerespect")]
    public required List<MemberContributor> OrganisedCrimeRespect { get; set; }

    [JsonProperty ("organisedcrimemoney")]
    public required List<MemberContributor> OrganisedCrimeMoney { get; set; }

    [JsonProperty ("organisedcrimesuccess")]
    public required List<MemberContributor> OrganisedCrimeSuccess { get; set; }

    [JsonProperty ("organisedcrimefail")]
    public required List<MemberContributor> OrganisedCrimeFail { get; set; }

    [JsonProperty ("attackswon")]
    public required List<MemberContributor> AttacksWon { get; set; }

    [JsonProperty ("attackslost")]
    public required List<MemberContributor> AttacksLost { get; set; }

    [JsonProperty ("attackschain")]
    public required List<MemberContributor> AttacksChain { get; set; }

    [JsonProperty ("attacksleave")]
    public required List<MemberContributor> AttacksLeave { get; set; }

    [JsonProperty ("attacksmug")]
    public required List<MemberContributor> AttacksMug { get; set; }

    [JsonProperty ("attackshosp")]
    public required List<MemberContributor> AttacksHosp { get; set; }

    [JsonProperty ("bestchain")]
    public required List<MemberContributor> BestChain { get; set; }

    [JsonProperty ("busts")]
    public required List<MemberContributor> Busts { get; set; }

    [JsonProperty ("revives")]
    public required List<MemberContributor> Revives { get; set; }

    [JsonProperty ("jails")]
    public required List<MemberContributor> Jails { get; set; }

    [JsonProperty ("hosps")]
    public required List<MemberContributor> Hosps { get; set; }

    [JsonProperty ("medicalitemrecovery")]
    public required List<MemberContributor> MedicalItemRecovery { get; set; }

    [JsonProperty ("medicalcooldownused")]
    public required List<MemberContributor> MedicalCooldownUsed { get; set; }

    [JsonProperty ("gymtrains")]
    public required List<MemberContributor> GymTrains { get; set; }

    [JsonProperty ("gymstrength")]
    public required List<MemberContributor> GymStrength { get; set; }

    [JsonProperty ("gymspeed")]
    public required List<MemberContributor> GymSpeed { get; set; }

    [JsonProperty ("gymdefense")]
    public required List<MemberContributor> GymDefense { get; set; }

    [JsonProperty ("gymdexterity")]
    public required List<MemberContributor> GymDexterity { get; set; }

    [JsonProperty ("candyused")]
    public required List<MemberContributor> CandyUsed { get; set; }

    [JsonProperty ("alcoholused")]
    public required List<MemberContributor> AlcoholUsed { get; set; }

    [JsonProperty ("energydrinkused")]
    public required List<MemberContributor> EnergyDrinkUsed { get; set; }

    [JsonProperty ("drugsused")]
    public required List<MemberContributor> DrugsUsed { get; set; }

    [JsonProperty ("drugoverdoses")]
    public required List<MemberContributor> DrugOverdoses { get; set; }

    [JsonProperty ("rehabs")]
    public required List<MemberContributor> Rehabs { get; set; }

    [JsonProperty ("caymaninterest")]
    public required List<MemberContributor> CaymanInterest { get; set; }

    [JsonProperty ("traveltimes")]
    public required List<MemberContributor> TravelTimes { get; set; }

    [JsonProperty ("traveltime")]
    public required List<MemberContributor> TravelTime { get; set; }

    [JsonProperty ("hunting")]
    public required List<MemberContributor> Hunting { get; set; }

    [JsonProperty ("attacksdamagehits")]
    public required List<MemberContributor> AttacksDamageHits { get; set; }

    [JsonProperty ("attacksdamage")]
    public required List<MemberContributor> AttacksDamage { get; set; }

    [JsonProperty ("hosptimegiven")]
    public required List<MemberContributor> HospTimeGiven { get; set; }

    [JsonProperty ("hosptimereceived")]
    public required List<MemberContributor> HospTimeReceived { get; set; }

    [JsonProperty ("attacksdamaging")]
    public required List<MemberContributor> AttacksDamaging { get; set; }

    [JsonProperty ("attacksrunaway")]
    public required List<MemberContributor> AttacksRunaway { get; set; }

    [JsonProperty ("highestterritories")]
    public required List<MemberContributor> HighestTerritories { get; set; }

    [JsonProperty ("territoryrespect")]
    public required List<MemberContributor> TerritoryRespect { get; set; }
}
