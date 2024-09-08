using Newtonsoft.Json;

namespace Bartender.Net.Faction.Territory;

public class Territory {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("coordinateX")]
    public required string CoordinateX { get; set; }

    [JsonProperty ("coordinateY")]
    public required string CoordinateY { get; set; }

    [JsonProperty ("dailyRespect")]
    public required int DailyRespect { get; set; }

    [JsonProperty ("density")]
    public required int Density { get; set; }

    [JsonProperty ("faction")]
    public required int Faction { get; set; }

    [JsonProperty ("racket")]
    public required Racket Racket { get; set; }

    [JsonProperty ("sector")]
    public required int Sector { get; set; }

    [JsonProperty ("size")]
    public required int Size { get; set; }

    [JsonProperty ("slots")]
    public required int Slots { get; set; }
}