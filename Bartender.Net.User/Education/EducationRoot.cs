using Newtonsoft.Json;

namespace Bartender.Net.User.Education;

public class EducationRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("education_current")]
    public required int EducationCurrent { get; set; }

    [JsonProperty ("education_timeleft")]
    public required int EducationTimeleft { get; set; }

    [JsonProperty ("education_completed")]
    public required List<int> EducationCompleted { get; set; }
}
