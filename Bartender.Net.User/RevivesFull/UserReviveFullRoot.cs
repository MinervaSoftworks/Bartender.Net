using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.RevivesFull;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.RevivesFull;

public class UserReviveFullRoot : BartenderEntity {
    [JsonProperty ("revives")]
    [NotMapped]
    public Dictionary<string, ReviveFull> Revives {
        get => RevivesList.ToTornDictionary ();
        set => RevivesList = value.TornDictionaryToList ();
    }

    public virtual List<ReviveFull> RevivesList { get; set; } = [];
}
