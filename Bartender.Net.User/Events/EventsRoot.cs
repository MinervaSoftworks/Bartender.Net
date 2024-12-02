using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Events;

public class EventsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("events")]
    [NotMapped]
    public Dictionary<string, Event> Events { get; set; } = default!;

    public virtual List<Event> EventsList {
        get => Events.TornDictionaryToList ();
        set => Events = value.ToTornDictionary ();
    }
}
