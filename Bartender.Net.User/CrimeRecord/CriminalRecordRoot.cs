using Newtonsoft.Json;

namespace Bartender.Net.User.CrimeRecord;

public class CriminalRecordRoot {
    [JsonProperty ("criminalrecord")]
    public required CrimnalRecordCollection Crimes { get; set; }
}
