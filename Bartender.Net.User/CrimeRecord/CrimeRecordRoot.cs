using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.CrimeRecord;

public class CrimeRecordRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("criminalrecord")]
    public virtual required CrimeRecordCollection Crimes { get; set; }
}
