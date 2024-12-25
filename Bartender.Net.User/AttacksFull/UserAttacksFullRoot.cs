using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.AttacksFull;

public class UserAttacksFullRoot : BartenderEntity {
    [JsonProperty ("attacks")]
    [NotMapped]
    public Dictionary<string, UserAttackFull> Attacks {
        get => AttacksList.ToTornDictionary ();
        set => AttacksList = value.TornDictionaryToList ();
    }

    public virtual List<UserAttackFull> AttacksList { get; set; } = [];
}