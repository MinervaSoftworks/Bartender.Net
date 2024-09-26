using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.CrimeRecord;

public class CrimeRecordRoot {
    [JsonProperty ("criminalrecord")]
    public required CrimeRecordCollection Crimes { get; set; }
}
