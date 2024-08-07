using Bartender.Net.Framework;
using Bartender.Net.Framework.Selection;
using Bartender.Net.Framework.User.PersonalStats;
using Newtonsoft.Json;

namespace Bartender.Net.User.PersonalStats;

public class PersonalStatsRoot : IPersonalStatsRoot {
    [JsonProperty ("personalstats")]
    [JsonConverter (typeof (ConcreteConverter<PersonalStats>))]
    public required IPersonalStats PersonalStats { get; set; }
}