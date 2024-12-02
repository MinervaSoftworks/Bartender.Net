using Bartender.Net.Framework;
using Bartender.Net.User.Messages;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.NewMessages;

public class NewUserMessagesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

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