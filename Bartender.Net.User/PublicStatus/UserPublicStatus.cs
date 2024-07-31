using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.User.Profile;
using Bartender.Net.Framework.User.PublicStatus;
using Newtonsoft.Json;

namespace Bartender.Net.User.PublicStatus;

public class UserPublicStatus : IUserPublicStatus {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("baned")]
    public bool Banned { get; set; }

    [JsonProperty ("playername")]
    public string PlayerName { get; set; }

    [JsonProperty ("status")]
    public string Status { get; set; }

    [JsonIgnore]
    public TornRole TornRole {
        get => Status.ToTornRole ();
        set => Status = value.ToTornRoleString ();
    }

    [JsonProperty ("userID")]
    public int UserID { get; set; }
}

