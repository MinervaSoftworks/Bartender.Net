using Bartender.Net.Common.User;
using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework;
using Bartender.Net.Framework.Selection;
using Bartender.Net.Framework.User.Bars;
using Bartender.Net.Framework.User.Profile;
using Bartender.Net.User.Bars;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class ProfileRoot : IProfileRoot {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("player_id")]
    public required int ProfileID { get; set; }

    [JsonProperty ("age")]
    public required int Age { get; set; }

    [JsonProperty ("awards")]
    public required int Awards { get; set; }

    [JsonProperty ("icons")]
    [JsonConverter (typeof(ConcreteConverter<Dictionary<string, string>>))]
    public required IDictionary<string, string> BasicIcons { get; set; }

    [JsonProperty ("competition")]
    [JsonConverter (typeof(ConcreteConverter<Competition>))]
    public required ICompetition Competition { get; set; }

    [JsonProperty ("donator")]
    public required bool Donator { get; set; }

    [JsonProperty ("enemies")]
    public required int Enemies { get; set; }

    [JsonProperty ("faction")]
    [JsonConverter (typeof(ConcreteConverter<FactionStub>))]
    public required IFactionStub Faction { get; set; }

    [JsonProperty ("forum_posts")]
    public required int ForumPosts { get; set; }

    [JsonProperty ("friends")]
    public required int Friends { get; set; }

    [JsonProperty ("gender")]
    public required string GenderString { get; set; }

    [JsonIgnore]
    public Gender Gender {
        get => GenderString.ToGender ();
        set => GenderString = value.ToGenderString ();
    }

    [JsonProperty ("honor")]
    public required int Honor { get; set; }

    [JsonProperty ("job")]
    [JsonConverter (typeof(ConcreteConverter<Job>))]
    public required IJob Job { get; set; }

    [JsonProperty ("karma")]
    public required int Karma { get; set; }

    [JsonProperty ("last_action")]
    [JsonConverter (typeof(ConcreteConverter<RelativeLastAction>))]
    public required IRelativeLastAction LastAction { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("life")]
    [JsonConverter (typeof(ConcreteConverter<Bar>))]
    public required IBar Life { get; set; }

    [JsonProperty ("marrige")]
    [JsonConverter (typeof(ConcreteConverter<Marriage>))]
    public required IMarriage Marriage { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("rank")]
    public required string Rank { get; set; }

    [JsonProperty ("revivable")]
    public required bool Revivable { get; set; }

    [JsonProperty ("role")]
    public required string Role { get; set; }

    [JsonProperty ("signup")]
    public required string Signup { get; set; }

    [JsonProperty ("states")]
    [JsonConverter (typeof(ConcreteConverter<PlayerStates>))]
    public required IPlayerStates States { get; set; }

    [JsonProperty ("status")]
    [JsonConverter (typeof(ConcreteConverter<Status>))]
    public required IStatus Status { get; set; }
}
