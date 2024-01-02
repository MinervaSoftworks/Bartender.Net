using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction {
    public class RankedWarFaction {
        public int RankedWarFactionID { get; set; }

        public RankedWar RankedWar { get; set; }

        [JsonProperty ("chain")]
        public int Chain { get; set; }

        [JsonProperty ("name")]
        public string Name { get; set; }

        [JsonProperty ("score")]
        public int Score { get; set; }
    }
}
