using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Education {
    [JsonProperty("education_current")]
    public int EducationCurrent { get; set; }

    [JsonProperty("education_timeleft")]
    public int EducationTimeleft { get; set; }

    [JsonProperty("education_completed")]
    public List<int> EducationCompleted { get; set; }
}
