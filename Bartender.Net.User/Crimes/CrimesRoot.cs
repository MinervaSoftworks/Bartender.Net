using Bartender.Net.Framework;
using Bartender.Net.User.CrimeRecord;
using Newtonsoft.Json;

namespace Bartender.Net.User.Crimes;

public class CrimesRoot : BartenderEntity {
    [JsonProperty ("criminalrecord")]
    public virtual required CrimeRecordCollection Crimes { get; set; }
}