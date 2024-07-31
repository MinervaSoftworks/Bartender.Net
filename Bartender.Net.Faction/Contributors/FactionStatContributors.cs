using Bartender.Net.Framework.Faction.Contributors;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Contributors;

public class FactionStatContributors : IFactionStatContributors {
    [JsonProperty ("medicalitemsused")]
    public IEnumerable<IFactionStatContributor> MedicalItemsUsed { get; set; }

    [JsonProperty ("criminaloffences")]
    public IEnumerable<IFactionStatContributor> CriminalOffences { get; set; }

    [JsonProperty ("organisedcrimerespect")]
    public IEnumerable<IFactionStatContributor> OrganisedCrimeRespect { get; set; }

    [JsonProperty ("organisedcrimemoney")]
    public IEnumerable<IFactionStatContributor> OrganisedCrimeMoney { get; set; }

    [JsonProperty ("organisedcrimesuccess")]
    public IEnumerable<IFactionStatContributor> OrganisedCrimeSuccess { get; set; }

    [JsonProperty ("organisedcrimefail")]
    public IEnumerable<IFactionStatContributor> OrganisedCrimeFail { get; set; }

    [JsonProperty ("attackswon")]
    public IEnumerable<IFactionStatContributor> AttacksWon { get; set; }

    [JsonProperty ("attackslost")]
    public IEnumerable<IFactionStatContributor> AttacksLost { get; set; }

    [JsonProperty ("attackschain")]
    public IEnumerable<IFactionStatContributor> AttacksChain { get; set; }

    [JsonProperty ("attacksleave")]
    public IEnumerable<IFactionStatContributor> AttacksLeave { get; set; }

    [JsonProperty ("attacksmug")]
    public IEnumerable<IFactionStatContributor> AttacksMug { get; set; }

    [JsonProperty ("attackshosp")]
    public IEnumerable<IFactionStatContributor> AttacksHosp { get; set; }

    [JsonProperty ("bestchain")]
    public IEnumerable<IFactionStatContributor> BestChain { get; set; }

    [JsonProperty ("busts")]
    public IEnumerable<IFactionStatContributor> Busts { get; set; }

    [JsonProperty ("revives")]
    public IEnumerable<IFactionStatContributor> Revives { get; set; }

    [JsonProperty ("jails")]
    public IEnumerable<IFactionStatContributor> Jails { get; set; }

    [JsonProperty ("hosps")]
    public IEnumerable<IFactionStatContributor> Hosps { get; set; }

    [JsonProperty ("medicalitemrecovery")]
    public IEnumerable<IFactionStatContributor> MedicalItemRecovery { get; set; }

    [JsonProperty ("medicalcooldownused")]
    public IEnumerable<IFactionStatContributor> MedicalCooldownUsed { get; set; }

    [JsonProperty ("gymtrains")]
    public IEnumerable<IFactionStatContributor> GymTrains { get; set; }

    [JsonProperty ("gymstrength")]
    public IEnumerable<IFactionStatContributor> GymStrength { get; set; }

    [JsonProperty ("gymspeed")]
    public IEnumerable<IFactionStatContributor> GymSpeed { get; set; }

    [JsonProperty ("gymdefense")]
    public IEnumerable<IFactionStatContributor> GymDefense { get; set; }

    [JsonProperty ("gymdexterity")]
    public IEnumerable<IFactionStatContributor> GymDexterity { get; set; }

    [JsonProperty ("candyused")]
    public IEnumerable<IFactionStatContributor> CandyUsed { get; set; }

    [JsonProperty ("alcoholused")]
    public IEnumerable<IFactionStatContributor> AlcoholUsed { get; set; }

    [JsonProperty ("energydrinkused")]
    public IEnumerable<IFactionStatContributor> EnergyDrinkUsed { get; set; }

    [JsonProperty ("drugsused")]
    public IEnumerable<IFactionStatContributor> DrugsUsed { get; set; }

    [JsonProperty ("drugoverdoses")]
    public IEnumerable<IFactionStatContributor> DrugOverdoses { get; set; }

    [JsonProperty ("rehabs")]
    public IEnumerable<IFactionStatContributor> Rehabs { get; set; }

    [JsonProperty ("caymaninterest")]
    public IEnumerable<IFactionStatContributor> CaymanInterest { get; set; }

    [JsonProperty ("traveltimes")]
    public IEnumerable<IFactionStatContributor> TravelTimes { get; set; }

    [JsonProperty ("traveltime")]
    public IEnumerable<IFactionStatContributor> TravelTime { get; set; }

    [JsonProperty ("hunting")]
    public IEnumerable<IFactionStatContributor> Hunting { get; set; }

    [JsonProperty ("attacksdamagehits")]
    public IEnumerable<IFactionStatContributor> AttacksDamageHits { get; set; }

    [JsonProperty ("attacksdamage")]
    public IEnumerable<IFactionStatContributor> AttacksDamage { get; set; }

    [JsonProperty ("hosptimegiven")]
    public IEnumerable<IFactionStatContributor> HospTimeGiven { get; set; }

    [JsonProperty ("hosptimereceived")]
    public IEnumerable<IFactionStatContributor> HospTimeReceived { get; set; }

    [JsonProperty ("attacksdamaging")]
    public IEnumerable<IFactionStatContributor> AttacksDamaging { get; set; }

    [JsonProperty ("attacksrunaway")]
    public IEnumerable<IFactionStatContributor> AttacksRunaway { get; set; }

    [JsonProperty ("highestterritories")]
    public IEnumerable<IFactionStatContributor> HighestTerritories { get; set; }

    [JsonProperty ("territoryrespect")]
    public IEnumerable<IFactionStatContributor> TerritoryRespect { get; set; }
}
