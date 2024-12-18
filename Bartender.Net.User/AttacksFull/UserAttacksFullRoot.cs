using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.AttacksFull;

public class UserAttacksFullRoot : BartenderEntity {
    [JsonProperty ("attacks")]
    [NotMapped]
    public Dictionary<string, UserAttackFull> Attacks { get; set; } = default!;

    public virtual List<UserAttackFull> AttacksList {
        get => Attacks.TornDictionaryToList ();
        set => Attacks = value.ToTornDictionary ();
    }
}