using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.User.Bars;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class UserProfile : IUserProfile {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("player_id")]
    public int ProfileID { get; set; }

    [JsonProperty ("age")]
    public int Age { get; set; }

    [JsonProperty ("awards")]
    public int Awards { get; set; }

    [JsonProperty ("icons")]
    public IDictionary<string, string> BasicIcons { get; set; }

    [JsonProperty ("competition")]
    public ICompetition Competition { get; set; }

    [JsonProperty ("donator")]
    public bool Donator { get; set; }

    [JsonProperty ("enemies")]
    public int Enemies { get; set; }

    [JsonProperty ("faction")]
    public IFactionStub Faction { get; set; }

    [JsonProperty ("forum_posts")]
    public int ForumPosts { get; set; }

    [JsonProperty ("friends")]
    public int Friends { get; set; }

    [JsonProperty ("gender")]
    public string GenderString { get; set; }

    [JsonIgnore]
    public Gender Gender {
        get => GenderString.ToGender ();
        set => GenderString = value.ToGenderString ();
    }

    [JsonProperty ("honor")]
    public int Honor { get; set; }

    [JsonProperty ("job")]
    public IJob Job { get; set; }

    [JsonProperty ("karma")]
    public int Karma { get; set; }

    [JsonProperty ("last_action")]
    public ILastAction LastAction { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("life")]
    public IBar Life { get; set; }

    [JsonProperty ("marrige")]
    public IMarriage Marriage { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("rank")]
    public string Rank { get; set; }

    [JsonProperty ("revivable")]
    public bool Revivable { get; set; }

    [JsonProperty ("role")]
    public string Role { get; set; }

    [JsonProperty ("signup")]
    public string Signup { get; set; }

    [JsonProperty ("states")]
    public IPlayerStates States { get; set; }

    [JsonProperty ("status")]
    public IStatus Status { get; set; }
}
