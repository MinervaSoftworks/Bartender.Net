using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class CriminalRecords {
    [JsonProperty ("criminalrecord")]
    public CriminalRecord Crimes { get; set; }
}
