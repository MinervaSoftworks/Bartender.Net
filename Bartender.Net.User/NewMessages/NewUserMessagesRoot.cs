using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Bartender.Net.User.Messages;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.NewMessages;

public class NewUserMessagesRoot : BartenderEntity {
    [JsonProperty ("messages")]
    [NotMapped]
    public Dictionary<string, UserMessage> Messages { get; set; } = default!;

    public virtual List<UserMessage> MessagesList {
        get => Messages.TornDictionaryToList ();
        set => Messages = value.ToTornDictionary ();
    }

    [JsonProperty ("player_id")]
    public required int PlayerID { get; set; }
}