using Newtonsoft.Json;

namespace Bartender.Net.Faction.Stats;

public class FactionStatsEntry {
    [JsonProperty ("medicalitemsused")]
    public int Medicalitemsused { get; set; }

    [JsonProperty ("criminaloffences")]
    public int Criminaloffences { get; set; }

    [JsonProperty ("organisedcrimerespect")]
    public int Organisedcrimerespect { get; set; }

    [JsonProperty ("organisedcrimemoney")]
    public long Organisedcrimemoney { get; set; }

    [JsonProperty ("organisedcrimesuccess")]
    public int Organisedcrimesuccess { get; set; }

    [JsonProperty ("organisedcrimefail")]
    public int Organisedcrimefail { get; set; }

    [JsonProperty ("attackswon")]
    public int Attackswon { get; set; }

    [JsonProperty ("attackslost")]
    public int Attackslost { get; set; }

    [JsonProperty ("attackschain")]
    public int Attackschain { get; set; }

    [JsonProperty ("attacksleave")]
    public int Attacksleave { get; set; }

    [JsonProperty ("attacksmug")]
    public int Attacksmug { get; set; }

    [JsonProperty ("attackshosp")]
    public int Attackshosp { get; set; }

    [JsonProperty ("bestchain")]
    public int Bestchain { get; set; }

    [JsonProperty ("busts")]
    public int Busts { get; set; }

    [JsonProperty ("revives")]
    public int Revives { get; set; }

    [JsonProperty ("jails")]
    public int Jails { get; set; }

    [JsonProperty ("hosps")]
    public int Hosps { get; set; }

    [JsonProperty ("medicalitemrecovery")]
    public int Medicalitemrecovery { get; set; }

    [JsonProperty ("medicalcooldownused")]
    public int Medicalcooldownused { get; set; }

    [JsonProperty ("gymtrains")]
    public int Gymtrains { get; set; }

    [JsonProperty ("gymstrength")]
    public int Gymstrength { get; set; }

    [JsonProperty ("gymspeed")]
    public int Gymspeed { get; set; }

    [JsonProperty ("gymdefense")]
    public int Gymdefense { get; set; }

    [JsonProperty ("gymdexterity")]
    public int Gymdexterity { get; set; }

    [JsonProperty ("candyused")]
    public int Candyused { get; set; }

    [JsonProperty ("alcoholused")]
    public int Alcoholused { get; set; }

    [JsonProperty ("energydrinkused")]
    public int Energydrinkused { get; set; }

    [JsonProperty ("drugsused")]
    public int Drugsused { get; set; }

    [JsonProperty ("drugoverdoses")]
    public int Drugoverdoses { get; set; }

    [JsonProperty ("rehabs")]
    public int Rehabs { get; set; }

    [JsonProperty ("caymaninterest")]
    public int Caymaninterest { get; set; }

    [JsonProperty ("traveltimes")]
    public int Traveltimes { get; set; }

    [JsonProperty ("traveltime")]
    public int Traveltime { get; set; }

    [JsonProperty ("hunting")]
    public int Hunting { get; set; }

    [JsonProperty ("attacksdamagehits")]
    public int Attacksdamagehits { get; set; }

    [JsonProperty ("attacksdamage")]
    public int Attacksdamage { get; set; }

    [JsonProperty ("hosptimegiven")]
    public int Hosptimegiven { get; set; }

    [JsonProperty ("hosptimereceived")]
    public int Hosptimereceived { get; set; }

    [JsonProperty ("attacksdamaging")]
    public int Attacksdamaging { get; set; }

    [JsonProperty ("attacksrunaway")]
    public int Attacksrunaway { get; set; }

    [JsonProperty ("highestterritories")]
    public int Highestterritories { get; set; }

    [JsonProperty ("territoryrespect")]
    public int Territoryrespect { get; set; }
}
