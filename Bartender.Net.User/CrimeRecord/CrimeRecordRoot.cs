using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.CrimeRecord;

public class CrimeRecordRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("criminalrecord")]
    public virtual required CrimeRecordCollection Crimes { get; set; }
}
