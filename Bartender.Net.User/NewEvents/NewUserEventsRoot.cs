using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.NewEvents;

public class NewUserEventsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("events")]
    [NotMapped]
    public Dictionary<string, NewUserEvent> Events { get; set; } = default!;

    public virtual List<NewUserEvent> EventsList {
        get => Events.TornDictionaryToList ();
        set => Events = value.ToTornDictionary ();
    }

    [JsonProperty ("player_id")]
    public required int PlayerID { get; set; }
}
