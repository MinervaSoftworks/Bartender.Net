using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Messages;

public class MessagesRoot : BartenderEntity {
    [JsonProperty ("messages")]
    [NotMapped]
    public Dictionary<string, UserMessage> Messages { get; set; } = default!;

    public virtual List<UserMessage> MessagesList {
        get => Messages.TornDictionaryToList ();
        set => Messages = value.ToTornDictionary ();
    }
}
