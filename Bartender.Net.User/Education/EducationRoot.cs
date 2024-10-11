using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Education;

public class EducationRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("education_current")]
    public required int EducationCurrent { get; set; }

    [JsonProperty ("education_timeleft")]
    public required int EducationTimeleft { get; set; }

    [JsonProperty ("education_completed")]
    public virtual required List<int> EducationCompleted { get; set; }
}
