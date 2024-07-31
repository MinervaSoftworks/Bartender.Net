using Bartender.Net.Framework.User.Skills;
using Newtonsoft.Json;

namespace Bartender.Net.User.Skills;

public class UserSkills : IUserSkills {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("bootlegging")]
    public string Bootlegging { get; set; }

    [JsonProperty ("burglary")]
    public string Burglary { get; set; }

    [JsonProperty ("card_skimming")]
    public string CardSkimming { get; set; }

    [JsonProperty ("cracking")]
    public string Cracking { get; set; }

    [JsonProperty ("graffiti")]
    public string Graffiti { get; set; }

    [JsonProperty ("search_for_cash")]
    public string SearchForCash { get; set; }

    [JsonProperty ("shoplifting")]
    public string Shoplifting { get; set; }

    [JsonProperty ("forgery")]
    public string Forgery { get; set; }

    [JsonProperty ("hustling")]
    public string Hustling { get; set; }

    [JsonProperty ("disposal")]
    public string Disposal { get; set; }

    [JsonProperty ("pickpocketing")]
    public string Pickpocketing { get; set; }

    [JsonProperty ("racing")]
    public string Racing { get; set; }

    [JsonProperty ("reviving")]
    public string Reviving { get; set; }

    [JsonProperty ("player_id")]
    public int PlayerId { get; set; }
}
