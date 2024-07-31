namespace Bartender.Net.Framework.Faction.Stats;

public interface IFactionStatsEntry {
    int Alcoholused { get; set; }
    int Attackschain { get; set; }
    int Attacksdamage { get; set; }
    int Attacksdamagehits { get; set; }
    int Attacksdamaging { get; set; }
    int Attackshosp { get; set; }
    int Attacksleave { get; set; }
    int Attackslost { get; set; }
    int Attacksmug { get; set; }
    int Attacksrunaway { get; set; }
    int Attackswon { get; set; }
    int Bestchain { get; set; }
    int Busts { get; set; }
    int Candyused { get; set; }
    int Caymaninterest { get; set; }
    int Criminaloffences { get; set; }
    int Drugoverdoses { get; set; }
    int Drugsused { get; set; }
    int Energydrinkused { get; set; }
    int Gymdefense { get; set; }
    int Gymdexterity { get; set; }
    int Gymspeed { get; set; }
    int Gymstrength { get; set; }
    int Gymtrains { get; set; }
    int Highestterritories { get; set; }
    int Hosps { get; set; }
    int Hosptimegiven { get; set; }
    int Hosptimereceived { get; set; }
    int Hunting { get; set; }
    int Jails { get; set; }
    int Medicalcooldownused { get; set; }
    int Medicalitemrecovery { get; set; }
    int Medicalitemsused { get; set; }
    int Organisedcrimefail { get; set; }
    long Organisedcrimemoney { get; set; }
    int Organisedcrimerespect { get; set; }
    int Organisedcrimesuccess { get; set; }
    int Rehabs { get; set; }
    int Revives { get; set; }
    int Territoryrespect { get; set; }
    int Traveltime { get; set; }
    int Traveltimes { get; set; }
}
