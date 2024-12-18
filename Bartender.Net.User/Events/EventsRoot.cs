using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Events;

public class EventsRoot : BartenderEntity {
    [JsonProperty ("events")]
    [NotMapped]
    public Dictionary<string, Event> Events { get; set; } = default!;

    public virtual List<Event> EventsList {
        get => Events.TornDictionaryToList ();
        set => Events = value.ToTornDictionary ();
    }
}
