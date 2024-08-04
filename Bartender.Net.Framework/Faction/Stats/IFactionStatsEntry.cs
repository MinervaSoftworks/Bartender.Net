namespace Bartender.Net.Framework.Faction.Stats;

public interface IFactionStatsEntry {
    int Alcoholused { get; }
    int Attackschain { get; }
    int Attacksdamage { get; }
    int Attacksdamagehits { get; }
    int Attacksdamaging { get; }
    int Attackshosp { get; }
    int Attacksleave { get; }
    int Attackslost { get; }
    int Attacksmug { get; }
    int Attacksrunaway { get; }
    int Attackswon { get; }
    int Bestchain { get; }
    int Busts { get; }
    int Candyused { get; }
    int Caymaninterest { get; }
    int Criminaloffences { get; }
    int Drugoverdoses { get; }
    int Drugsused { get; }
    int Energydrinkused { get; }
    int Gymdefense { get; }
    int Gymdexterity { get; }
    int Gymspeed { get; }
    int Gymstrength { get; }
    int Gymtrains { get; }
    int Highestterritories { get; }
    int Hosps { get; }
    int Hosptimegiven { get; }
    int Hosptimereceived { get; }
    int Hunting { get; }
    int Jails { get; }
    int Medicalcooldownused { get; }
    int Medicalitemrecovery { get; }
    int Medicalitemsused { get; }
    int Organisedcrimefail { get; }
    long Organisedcrimemoney { get; }
    int Organisedcrimerespect { get; }
    int Organisedcrimesuccess { get; }
    int Rehabs { get; }
    int Revives { get; }
    int Territoryrespect { get; }
    int Traveltime { get; }
    int Traveltimes { get; }
}
