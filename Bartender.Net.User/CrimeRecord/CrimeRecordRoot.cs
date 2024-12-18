using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.CrimeRecord;

public class CrimeRecordRoot : BartenderEntity {
    [JsonProperty ("criminalrecord")]
    public virtual required CrimeRecordCollection Crimes { get; set; }
}
