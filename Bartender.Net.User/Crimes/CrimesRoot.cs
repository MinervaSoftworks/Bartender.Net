using Bartender.Net.Framework;
using Bartender.Net.User.CrimeRecord;
using Newtonsoft.Json;

namespace Bartender.Net.User.Crimes;

public class CrimesRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("criminalrecord")]
    public required CrimnalRecordCollection Crimes { get; set; }
}