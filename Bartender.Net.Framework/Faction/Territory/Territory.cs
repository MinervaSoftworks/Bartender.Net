using Newtonsoft.Json;

namespace Bartender.Net.Framework.Faction.Territory;

public class Territory : ITerritory {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("coordinateX")]
    public string CoordinateX { get; set; }

    [JsonProperty ("coordinateY")]
    public string CoordinateY { get; set; }

    [JsonProperty ("dailyRespect")]
    public int DailyRespect { get; set; }

    [JsonProperty ("density")]
    public int Density { get; set; }

    [JsonProperty ("faction")]
    public int Faction { get; set; }

    [JsonProperty ("racket")]
    public IRacket Racket { get; set; }

    [JsonProperty ("sector")]
    public int Sector { get; set; }

    [JsonProperty ("size")]
    public int Size { get; set; }

    [JsonProperty ("slots")]
    public int Slots { get; set; }
}