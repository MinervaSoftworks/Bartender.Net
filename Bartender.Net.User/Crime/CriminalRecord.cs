using Bartender.Net.Framework.User.Crime;
using Newtonsoft.Json;

namespace Bartender.Net.User.Crime;

public class CriminalRecord : ICriminalRecord {
    [JsonProperty ("criminalrecord")]
    public required ICrimnalRecordCollection Crimes { get; set; }
}
