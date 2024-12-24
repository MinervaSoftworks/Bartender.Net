using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Attacks;

public class UserAttacksRoot : BartenderEntity {
    [JsonProperty ("attacks")]
    [NotMapped]
    public Dictionary<string, UserAttack> Attacks {
        get => AttacksList.ToTornDictionary ();
        set => AttacksList = value.TornDictionaryToList ();
    }

    public virtual List<UserAttack> AttacksList { get; set; } = [];
}
