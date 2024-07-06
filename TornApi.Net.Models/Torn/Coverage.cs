using Newtonsoft.Json;

namespace TornApi.Net.Models.Torn;

public class Coverage {
    [JsonIgnore]
    public int ID { get; set; }
    
    [JsonProperty ("Full Body Coverage")]
    public double FullBodyCoverage { get; set; }

    [JsonProperty ("Heart Coverage")]
    public double HeartCoverage { get; set; }

    [JsonProperty ("Stomach Coverage")]
    public double StomachCoverage { get; set; }

    [JsonProperty ("Chest Coverage")]
    public double ChestCoverage { get; set; }

    [JsonProperty ("Arm Coverage")]
    public double ArmCoverage { get; set; }

    [JsonProperty ("Throat Coverage")]
    public double ThroatCoverage { get; set; }

    [JsonProperty ("Groin Coverage")]
    public double GroinCoverage { get; set; }

    [JsonProperty ("Hand Coverage")]
    public double HandCoverage { get; set; }

    [JsonProperty ("Leg Coverage")]
    public double LegCoverage { get; set; }

    [JsonProperty ("Foot Coverage")]
    public double FootCoverage { get; set; }

    [JsonProperty ("Head Coverage")]
    public double HeadCoverage { get; set; }
}
