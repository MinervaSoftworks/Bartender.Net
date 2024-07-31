namespace Bartender.Net.Framework.Faction.Contributors;

public interface IFactionStatContributors
{
    IEnumerable<IFactionStatContributor> AlcoholUsed { get; set; }
    IEnumerable<IFactionStatContributor> AttacksChain { get; set; }
    IEnumerable<IFactionStatContributor> AttacksDamage { get; set; }
    IEnumerable<IFactionStatContributor> AttacksDamageHits { get; set; }
    IEnumerable<IFactionStatContributor> AttacksDamaging { get; set; }
    IEnumerable<IFactionStatContributor> AttacksHosp { get; set; }
    IEnumerable<IFactionStatContributor> AttacksLeave { get; set; }
    IEnumerable<IFactionStatContributor> AttacksLost { get; set; }
    IEnumerable<IFactionStatContributor> AttacksMug { get; set; }
    IEnumerable<IFactionStatContributor> AttacksRunaway { get; set; }
    IEnumerable<IFactionStatContributor> AttacksWon { get; set; }
    IEnumerable<IFactionStatContributor> BestChain { get; set; }
    IEnumerable<IFactionStatContributor> Busts { get; set; }
    IEnumerable<IFactionStatContributor> CandyUsed { get; set; }
    IEnumerable<IFactionStatContributor> CaymanInterest { get; set; }
    IEnumerable<IFactionStatContributor> CriminalOffences { get; set; }
    IEnumerable<IFactionStatContributor> DrugOverdoses { get; set; }
    IEnumerable<IFactionStatContributor> DrugsUsed { get; set; }
    IEnumerable<IFactionStatContributor> EnergyDrinkUsed { get; set; }
    IEnumerable<IFactionStatContributor> GymDefense { get; set; }
    IEnumerable<IFactionStatContributor> GymDexterity { get; set; }
    IEnumerable<IFactionStatContributor> GymSpeed { get; set; }
    IEnumerable<IFactionStatContributor> GymStrength { get; set; }
    IEnumerable<IFactionStatContributor> GymTrains { get; set; }
    IEnumerable<IFactionStatContributor> HighestTerritories { get; set; }
    IEnumerable<IFactionStatContributor> Hosps { get; set; }
    IEnumerable<IFactionStatContributor> HospTimeGiven { get; set; }
    IEnumerable<IFactionStatContributor> HospTimeReceived { get; set; }
    IEnumerable<IFactionStatContributor> Hunting { get; set; }
    IEnumerable<IFactionStatContributor> Jails { get; set; }
    IEnumerable<IFactionStatContributor> MedicalCooldownUsed { get; set; }
    IEnumerable<IFactionStatContributor> MedicalItemRecovery { get; set; }
    IEnumerable<IFactionStatContributor> MedicalItemsUsed { get; set; }
    IEnumerable<IFactionStatContributor> OrganisedCrimeFail { get; set; }
    IEnumerable<IFactionStatContributor> OrganisedCrimeMoney { get; set; }
    IEnumerable<IFactionStatContributor> OrganisedCrimeRespect { get; set; }
    IEnumerable<IFactionStatContributor> OrganisedCrimeSuccess { get; set; }
    IEnumerable<IFactionStatContributor> Rehabs { get; set; }
    IEnumerable<IFactionStatContributor> Revives { get; set; }
    IEnumerable<IFactionStatContributor> TerritoryRespect { get; set; }
    IEnumerable<IFactionStatContributor> TravelTime { get; set; }
    IEnumerable<IFactionStatContributor> TravelTimes { get; set; }
}
