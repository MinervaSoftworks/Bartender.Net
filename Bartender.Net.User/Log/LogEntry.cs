using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Log;

public class LogEntry : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("category")]
    public required string Category { get; set; }

    [JsonProperty ("data")]
    [NotMapped]
    public Dictionary<string, int> Data { get; set; } = default!;

    public virtual List<int> DataList {
        get => Data.TornDictionaryToList ();
        set => Data = value.ToTornDictionary ();
    }

    [JsonProperty ("log")]
    public required string LogType { get; set; }

    [JsonProperty ("params")]
    [NotMapped]
    public Dictionary<string, string> Params { get; set; } = default!;

    public virtual List<string> ParamsList {
        get => Params.TornDictionaryToList ();
        set => Params = value.ToTornDictionary ();
    }

    [JsonProperty ("timestamp")]
    public long Timestamp { get; set; }

    [JsonProperty ("title")]
    public required string Title { get; set; }
}
