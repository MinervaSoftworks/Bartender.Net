using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.Reports;
using Newtonsoft.Json;

namespace Bartender.Net.User.Reports;

public class UserReportsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("reports")]
    public virtual required List<Report> Reports { get; set; }
}
