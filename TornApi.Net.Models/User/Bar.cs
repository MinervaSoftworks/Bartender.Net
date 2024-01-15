using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Bar {
    [JsonIgnore]
    public int ID { get; set; }

    public int BarID { get; set; }

    [JsonProperty ("current")]
    public int Current { get; set; }

    [JsonProperty ("fulltime")]
    public int Fulltime { get; set; }

    [JsonProperty ("increment")]
    public int Increment { get; set; }

    [JsonProperty ("interval")]
    public int Interval { get; set; }

    [JsonProperty ("Maximum")]
    public int Maximum { get; set; }

    [JsonProperty ("ticktime")]
    public int Ticktime { get; set; }
}
