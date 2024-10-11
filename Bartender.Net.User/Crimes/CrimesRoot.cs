using Bartender.Net.Framework;
using Bartender.Net.User.CrimeRecord;
using Newtonsoft.Json;

namespace Bartender.Net.User.Crimes;

public class CrimesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("criminalrecord")]
    public virtual required CrimeRecordCollection Crimes { get; set; }
}