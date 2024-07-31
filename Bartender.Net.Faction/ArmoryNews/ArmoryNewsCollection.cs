using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.ArmoryNews;

public class ArmoryNewsCollection : INewsEntries {
    [JsonProperty ("armorynews")]
    public IDictionary<string, INewsEntry> News { get; set; }
}
