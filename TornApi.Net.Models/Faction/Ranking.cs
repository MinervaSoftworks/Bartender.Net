﻿using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction {
    public class Ranking {
        [JsonProperty ("division")]
        public int Division { get; set; }

        [JsonProperty ("level")]
        public int Level { get; set; }

        [JsonProperty ("name")]
        public Rank Rank { get; set; }

        [JsonProperty ("position")]
        public int Position { get; set; }

        [JsonProperty ("wins")]
        public int Wins { get; set; }
    }
}
