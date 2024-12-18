using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Attacks;

public class UserAttacksRoot : BartenderEntity {
    [JsonProperty ("attacks")]
    [NotMapped]
    public Dictionary<string, UserAttack> Attacks { get; set; } = default!;

    public virtual List<UserAttack> AttacksList {
        get => Attacks.TornDictionaryToList ();
        set => Attacks = value.ToTornDictionary ();
    }
}
