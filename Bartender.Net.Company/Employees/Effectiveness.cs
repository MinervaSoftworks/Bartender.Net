using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class Effectiveness {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("working_stats")]
    public int WorkingStats { get; set; }

    [JsonProperty ("settled_in")]
    public int SettledIn { get; set; }

    [JsonProperty ("merits")]
    public int Merits { get; set; }

    [JsonProperty ("director_education")]
    public int DirectorEducation { get; set; }

    [JsonProperty ("total")]
    public int Total { get; set; }

    [JsonProperty ("addiction")]
    public int Addiction { get; set; }

    [JsonProperty ("management")]
    public int Management { get; set; }
}
