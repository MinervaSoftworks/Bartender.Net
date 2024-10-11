using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Contributors;

public class StatContributors : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("medicalitemsused")]
    public virtual required List<MemberContributor> MedicalItemsUsed { get; set; }

    [JsonProperty ("criminaloffences")]
    public virtual required List<MemberContributor> CriminalOffences { get; set; }

    [JsonProperty ("organisedcrimerespect")]
    public virtual required List<MemberContributor> OrganisedCrimeRespect { get; set; }

    [JsonProperty ("organisedcrimemoney")]
    public virtual required List<MemberContributor> OrganisedCrimeMoney { get; set; }

    [JsonProperty ("organisedcrimesuccess")]
    public virtual required List<MemberContributor> OrganisedCrimeSuccess { get; set; }

    [JsonProperty ("organisedcrimefail")]
    public virtual required List<MemberContributor> OrganisedCrimeFail { get; set; }

    [JsonProperty ("attackswon")]
    public virtual required List<MemberContributor> AttacksWon { get; set; }

    [JsonProperty ("attackslost")]
    public virtual required List<MemberContributor> AttacksLost { get; set; }

    [JsonProperty ("attackschain")]
    public virtual required List<MemberContributor> AttacksChain { get; set; }

    [JsonProperty ("attacksleave")]
    public virtual required List<MemberContributor> AttacksLeave { get; set; }

    [JsonProperty ("attacksmug")]
    public virtual required List<MemberContributor> AttacksMug { get; set; }

    [JsonProperty ("attackshosp")]
    public virtual required List<MemberContributor> AttacksHosp { get; set; }

    [JsonProperty ("bestchain")]
    public virtual required List<MemberContributor> BestChain { get; set; }

    [JsonProperty ("busts")]
    public virtual required List<MemberContributor> Busts { get; set; }

    [JsonProperty ("revives")]
    public virtual required List<MemberContributor> Revives { get; set; }

    [JsonProperty ("jails")]
    public virtual required List<MemberContributor> Jails { get; set; }

    [JsonProperty ("hosps")]
    public virtual required List<MemberContributor> Hosps { get; set; }

    [JsonProperty ("medicalitemrecovery")]
    public virtual required List<MemberContributor> MedicalItemRecovery { get; set; }

    [JsonProperty ("medicalcooldownused")]
    public virtual required List<MemberContributor> MedicalCooldownUsed { get; set; }

    [JsonProperty ("gymtrains")]
    public virtual required List<MemberContributor> GymTrains { get; set; }

    [JsonProperty ("gymstrength")]
    public virtual required List<MemberContributor> GymStrength { get; set; }

    [JsonProperty ("gymspeed")]
    public virtual required List<MemberContributor> GymSpeed { get; set; }

    [JsonProperty ("gymdefense")]
    public virtual required List<MemberContributor> GymDefense { get; set; }

    [JsonProperty ("gymdexterity")]
    public virtual required List<MemberContributor> GymDexterity { get; set; }

    [JsonProperty ("candyused")]
    public virtual required List<MemberContributor> CandyUsed { get; set; }

    [JsonProperty ("alcoholused")]
    public virtual required List<MemberContributor> AlcoholUsed { get; set; }

    [JsonProperty ("energydrinkused")]
    public virtual required List<MemberContributor> EnergyDrinkUsed { get; set; }

    [JsonProperty ("drugsused")]
    public virtual required List<MemberContributor> DrugsUsed { get; set; }

    [JsonProperty ("drugoverdoses")]
    public virtual required List<MemberContributor> DrugOverdoses { get; set; }

    [JsonProperty ("rehabs")]
    public virtual required List<MemberContributor> Rehabs { get; set; }

    [JsonProperty ("caymaninterest")]
    public virtual required List<MemberContributor> CaymanInterest { get; set; }

    [JsonProperty ("traveltimes")]
    public virtual required List<MemberContributor> TravelTimes { get; set; }

    [JsonProperty ("traveltime")]
    public virtual required List<MemberContributor> TravelTime { get; set; }

    [JsonProperty ("hunting")]
    public virtual required List<MemberContributor> Hunting { get; set; }

    [JsonProperty ("attacksdamagehits")]
    public virtual required List<MemberContributor> AttacksDamageHits { get; set; }

    [JsonProperty ("attacksdamage")]
    public virtual required List<MemberContributor> AttacksDamage { get; set; }

    [JsonProperty ("hosptimegiven")]
    public virtual required List<MemberContributor> HospTimeGiven { get; set; }

    [JsonProperty ("hosptimereceived")]
    public virtual required List<MemberContributor> HospTimeReceived { get; set; }

    [JsonProperty ("attacksdamaging")]
    public virtual required List<MemberContributor> AttacksDamaging { get; set; }

    [JsonProperty ("attacksrunaway")]
    public virtual required List<MemberContributor> AttacksRunaway { get; set; }

    [JsonProperty ("highestterritories")]
    public virtual required List<MemberContributor> HighestTerritories { get; set; }

    [JsonProperty ("territoryrespect")]
    public virtual required List<MemberContributor> TerritoryRespect { get; set; }
}
