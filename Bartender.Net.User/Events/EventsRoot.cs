using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Events;

public class EventsRoot : BartenderEntity {
    [JsonProperty ("events")]
    [NotMapped]
    public Dictionary<string, Event> Events {
        get => EventsList.ToTornDictionary ();
        set => EventsList = value.TornDictionaryToList ();
    }

    public virtual List<Event> EventsList { get; set; } = [];
}
