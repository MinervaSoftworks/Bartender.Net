using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.Reports;
using Newtonsoft.Json;

namespace Bartender.Net.User.Reports;

public class UserReportsRoot : BartenderEntity {
    [JsonProperty ("reports")]
    public virtual required List<Report> Reports { get; set; }
}
