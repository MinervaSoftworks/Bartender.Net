using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.NewEvents;

public class NewUserEventsRoot : BartenderEntity {
    [JsonProperty ("events")]
    [NotMapped]
    public Dictionary<string, NewUserEvent> Events {
        get => EventsList.ToTornDictionary ();
        set => EventsList = value.TornDictionaryToList ();
    }

    public virtual List<NewUserEvent> EventsList { get; set; } = [];

    [JsonProperty ("player_id")]
    public required int PlayerID { get; set; }
}
