using Bartender.Net.Framework.User.Education;
using Newtonsoft.Json;

namespace Bartender.Net.User.Edu;

public class UserEducation : IUserEducation {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("education_current")]
    public int EducationCurrent { get; set; }

    [JsonProperty ("education_timeleft")]
    public int EducationTimeleft { get; set; }

    [JsonProperty ("education_completed")]
    public List<int> EducationCompleted { get; set; }
}
