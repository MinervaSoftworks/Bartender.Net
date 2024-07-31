using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.ArmoryNews;

public class ArmoryNewsCollection : IFactionNews {
    [JsonProperty ("armorynews")]
    public IDictionary<string, IFactionNewsEntry> News { get; set; }
}
