using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction {
    public class RankedWar {
        public int RankedWarID { get; set; }

        [JsonProperty ("factions")]
        public IDictionary<string, RankedWarFaction> Factions { get; set; }

        [JsonProperty ("war")]
        public War War { get; set; }
    }
}
