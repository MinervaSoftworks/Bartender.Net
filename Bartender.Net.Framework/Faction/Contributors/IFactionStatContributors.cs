namespace Bartender.Net.Framework.Faction.Contributors;

public interface IFactionStatContributors {
    IEnumerable<IFactionStatContributor> AlcoholUsed { get; }
    IEnumerable<IFactionStatContributor> AttacksChain { get; }
    IEnumerable<IFactionStatContributor> AttacksDamage { get; }
    IEnumerable<IFactionStatContributor> AttacksDamageHits { get; }
    IEnumerable<IFactionStatContributor> AttacksDamaging { get; }
    IEnumerable<IFactionStatContributor> AttacksHosp { get; }
    IEnumerable<IFactionStatContributor> AttacksLeave { get; }
    IEnumerable<IFactionStatContributor> AttacksLost { get; }
    IEnumerable<IFactionStatContributor> AttacksMug { get; }
    IEnumerable<IFactionStatContributor> AttacksRunaway { get; }
    IEnumerable<IFactionStatContributor> AttacksWon { get; }
    IEnumerable<IFactionStatContributor> BestChain { get; }
    IEnumerable<IFactionStatContributor> Busts { get; }
    IEnumerable<IFactionStatContributor> CandyUsed { get; }
    IEnumerable<IFactionStatContributor> CaymanInterest { get; }
    IEnumerable<IFactionStatContributor> CriminalOffences { get; }
    IEnumerable<IFactionStatContributor> DrugOverdoses { get; }
    IEnumerable<IFactionStatContributor> DrugsUsed { get; }
    IEnumerable<IFactionStatContributor> EnergyDrinkUsed { get; }
    IEnumerable<IFactionStatContributor> GymDefense { get; }
    IEnumerable<IFactionStatContributor> GymDexterity { get; }
    IEnumerable<IFactionStatContributor> GymSpeed { get; }
    IEnumerable<IFactionStatContributor> GymStrength { get; }
    IEnumerable<IFactionStatContributor> GymTrains { get; }
    IEnumerable<IFactionStatContributor> HighestTerritories { get; }
    IEnumerable<IFactionStatContributor> Hosps { get; }
    IEnumerable<IFactionStatContributor> HospTimeGiven { get; }
    IEnumerable<IFactionStatContributor> HospTimeReceived { get; }
    IEnumerable<IFactionStatContributor> Hunting { get; }
    IEnumerable<IFactionStatContributor> Jails { get; }
    IEnumerable<IFactionStatContributor> MedicalCooldownUsed { get; }
    IEnumerable<IFactionStatContributor> MedicalItemRecovery { get; }
    IEnumerable<IFactionStatContributor> MedicalItemsUsed { get; }
    IEnumerable<IFactionStatContributor> OrganisedCrimeFail { get; }
    IEnumerable<IFactionStatContributor> OrganisedCrimeMoney { get; }
    IEnumerable<IFactionStatContributor> OrganisedCrimeRespect { get; }
    IEnumerable<IFactionStatContributor> OrganisedCrimeSuccess { get; }
    IEnumerable<IFactionStatContributor> Rehabs { get; }
    IEnumerable<IFactionStatContributor> Revives { get; }
    IEnumerable<IFactionStatContributor> TerritoryRespect { get; }
    IEnumerable<IFactionStatContributor> TravelTime { get; }
    IEnumerable<IFactionStatContributor> TravelTimes { get; }
}
