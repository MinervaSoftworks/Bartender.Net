using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.User;
using Bartender.Net.Framework.Extensions;
using Bartender.Net.Framework.Extensions.User;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Profile;

public class UserProfileRoot : BartenderEntity {
    [JsonProperty ("player_id")]
    [NotMapped]
    public required int ProfileID {
        get => TornID;
        set => TornID = value;
    }

    [JsonProperty ("age")]
    public required int Age { get; set; }

    [JsonProperty ("awards")]
    public required int Awards { get; set; }

    [JsonProperty ("icons")]
    [NotMapped]
    public Dictionary<string, string> BasicIcons { get; set; } = new Dictionary<string, string> ();

    [JsonProperty ("competition")]
    [NotMapped]
    public virtual required Competition Competition { get; set; }

    [JsonProperty ("donator")]
    public required bool Donator { get; set; }

    [JsonProperty ("enemies")]
    public required int Enemies { get; set; }

    [JsonProperty ("faction")]
    public virtual required FactionStub Faction { get; set; }

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
    public required Job Job { get; set; }

    [JsonProperty ("karma")]
    public required int Karma { get; set; }

    [JsonProperty ("last_action")]
    public virtual required RelativeLastAction LastAction { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("life")]
    public virtual required LifeBar Life { get; set; }

    [JsonProperty ("married")]
    public virtual required Marriage Marriage { get; set; }

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
    public virtual required PlayerStates States { get; set; }

    [JsonProperty ("status")]
    public virtual required Status Status { get; set; }
}
