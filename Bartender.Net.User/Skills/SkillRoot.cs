using Bartender.Net.Framework.Selection;
using Bartender.Net.Framework.User.Skills;
using Newtonsoft.Json;

namespace Bartender.Net.User.Skills;

public class SkillRoot : ISkillRoot, ISelectionRoot {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("bootlegging")]
    public required string Bootlegging { get; set; }

    [JsonProperty ("burglary")]
    public required string Burglary { get; set; }

    [JsonProperty ("card_skimming")]
    public required string CardSkimming { get; set; }

    [JsonProperty ("cracking")]
    public required string Cracking { get; set; }

    [JsonProperty ("graffiti")]
    public required string Graffiti { get; set; }

    [JsonProperty ("search_for_cash")]
    public required string SearchForCash { get; set; }

    [JsonProperty ("shoplifting")]
    public required string Shoplifting { get; set; }

    [JsonProperty ("forgery")]
    public required string Forgery { get; set; }

    [JsonProperty ("hustling")]
    public required string Hustling { get; set; }

    [JsonProperty ("disposal")]
    public required string Disposal { get; set; }

    [JsonProperty ("pickpocketing")]
    public required string Pickpocketing { get; set; }

    [JsonProperty ("racing")]
    public required string Racing { get; set; }

    [JsonProperty ("reviving")]
    public required string Reviving { get; set; }

    [JsonProperty ("player_id")]
    public required int PlayerId { get; set; }

    public AccessLevel AccessLevelRequired => AccessLevel.Minimal;

    public string EndpointString => "skills";

    public string Name => "Skills";
}
