using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Stats;

public class StatsEntry : BartenderEntity {
    [JsonProperty ("medicalitemsused")]
    public required int Medicalitemsused { get; set; }

    [JsonProperty ("criminaloffences")]
    public required int Criminaloffences { get; set; }

    [JsonProperty ("organisedcrimerespect")]
    public required int Organisedcrimerespect { get; set; }

    [JsonProperty ("organisedcrimemoney")]
    public required long Organisedcrimemoney { get; set; }

    [JsonProperty ("organisedcrimesuccess")]
    public required int Organisedcrimesuccess { get; set; }

    [JsonProperty ("organisedcrimefail")]
    public required int Organisedcrimefail { get; set; }

    [JsonProperty ("attackswon")]
    public required int Attackswon { get; set; }

    [JsonProperty ("attackslost")]
    public required int Attackslost { get; set; }

    [JsonProperty ("attackschain")]
    public required int Attackschain { get; set; }

    [JsonProperty ("attacksleave")]
    public required int Attacksleave { get; set; }

    [JsonProperty ("attacksmug")]
    public required int Attacksmug { get; set; }

    [JsonProperty ("attackshosp")]
    public required int Attackshosp { get; set; }

    [JsonProperty ("bestchain")]
    public required int Bestchain { get; set; }

    [JsonProperty ("busts")]
    public required int Busts { get; set; }

    [JsonProperty ("revives")]
    public required int Revives { get; set; }

    [JsonProperty ("jails")]
    public required int Jails { get; set; }

    [JsonProperty ("hosps")]
    public required int Hosps { get; set; }

    [JsonProperty ("medicalitemrecovery")]
    public required int Medicalitemrecovery { get; set; }

    [JsonProperty ("medicalcooldownused")]
    public required int Medicalcooldownused { get; set; }

    [JsonProperty ("gymtrains")]
    public required int Gymtrains { get; set; }

    [JsonProperty ("gymstrength")]
    public required int Gymstrength { get; set; }

    [JsonProperty ("gymspeed")]
    public required int Gymspeed { get; set; }

    [JsonProperty ("gymdefense")]
    public required int Gymdefense { get; set; }

    [JsonProperty ("gymdexterity")]
    public required int Gymdexterity { get; set; }

    [JsonProperty ("candyused")]
    public required int Candyused { get; set; }

    [JsonProperty ("alcoholused")]
    public required int Alcoholused { get; set; }

    [JsonProperty ("energydrinkused")]
    public required int Energydrinkused { get; set; }

    [JsonProperty ("drugsused")]
    public required int Drugsused { get; set; }

    [JsonProperty ("drugoverdoses")]
    public required int Drugoverdoses { get; set; }

    [JsonProperty ("rehabs")]
    public required int Rehabs { get; set; }

    [JsonProperty ("caymaninterest")]
    public required int Caymaninterest { get; set; }

    [JsonProperty ("traveltimes")]
    public required int Traveltimes { get; set; }

    [JsonProperty ("traveltime")]
    public required int Traveltime { get; set; }

    [JsonProperty ("hunting")]
    public required int Hunting { get; set; }

    [JsonProperty ("attacksdamagehits")]
    public required int Attacksdamagehits { get; set; }

    [JsonProperty ("attacksdamage")]
    public required int Attacksdamage { get; set; }

    [JsonProperty ("hosptimegiven")]
    public required int Hosptimegiven { get; set; }

    [JsonProperty ("hosptimereceived")]
    public required int Hosptimereceived { get; set; }

    [JsonProperty ("attacksdamaging")]
    public required int Attacksdamaging { get; set; }

    [JsonProperty ("attacksrunaway")]
    public required int Attacksrunaway { get; set; }

    [JsonProperty ("highestterritories")]
    public required int Highestterritories { get; set; }

    [JsonProperty ("territoryrespect")]
    public required int Territoryrespect { get; set; }
}
