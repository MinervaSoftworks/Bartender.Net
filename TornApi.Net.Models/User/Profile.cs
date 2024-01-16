using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Profile {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("age")]
    public int Age { get; set; }

    [JsonProperty ("awards")]
    public int Awards { get; set; }

    [JsonProperty ("icons")]
    public IDictionary<string, string> BasicIcons { get; set; }

    [JsonProperty ("competition")]
    public Competition Competition { get; set; }

    [JsonProperty ("donator")]
    public bool Donator { get; set; }

    [JsonProperty ("enemies")]
    public int Enemies { get; set; }

    [JsonProperty ("faction")]
    public FactionStub Faction { get; set; }

    [JsonProperty ("forum_posts")]
    public int ForumPosts { get; set; }

    [JsonProperty ("friends")]
    public int Friends { get; set; }

    [JsonProperty ("gender")]
    public Gender Gender { get; set; }

    [JsonProperty ("honor")]
    public int Honor { get; set; }

    [JsonProperty ("job")]
    public Job Job { get; set; }

    [JsonProperty ("karma")]
    public int Karma { get; set; }

    [JsonProperty ("last_action")]
    public LastAction LastAction { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("life")]
    public Bar Life { get; set; }

    [JsonProperty ("marrige")]
    public Marriage Marriage { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("player_id")]
    public int ProfileID { get; set; }

    [JsonProperty ("rank")]
    public string Rank { get; set; }

    [JsonProperty ("revivable")]
    public bool Revivable { get; set; }

    [JsonProperty ("role")]
    public string Role { get; set; }

    [JsonProperty ("signup")]
    public string Signup { get; set; }

    [JsonProperty ("states")]
    public PlayerStates States { get; set; }

    [JsonProperty ("status")]
    public Status Status { get; set; }
}
