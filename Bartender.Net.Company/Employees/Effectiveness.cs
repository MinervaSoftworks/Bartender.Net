using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class Effectiveness : BartenderEntity {
    [JsonProperty ("working_stats")]
    public required int WorkingStats { get; set; }

    [JsonProperty ("settled_in")]
    public required int SettledIn { get; set; }

    [JsonProperty ("merits")]
    public required int Merits { get; set; }

    [JsonProperty ("director_education")]
    public required int DirectorEducation { get; set; }

    [JsonProperty ("total")]
    public required int Total { get; set; }

    [JsonProperty ("addiction")]
    public required int Addiction { get; set; }

    [JsonProperty ("management")]
    public required int Management { get; set; }
}
