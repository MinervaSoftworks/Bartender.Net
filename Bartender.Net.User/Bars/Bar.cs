using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bars;

public class Bar : BartenderEntity {
    [JsonProperty ("current")]
    public required int Current { get; set; }

    [JsonProperty ("fulltime")]
    public required int Fulltime { get; set; }

    [JsonProperty ("increment")]
    public required int Increment { get; set; }

    [JsonProperty ("interval")]
    public required int Interval { get; set; }

    [JsonProperty ("maximum")]
    public required int Maximum { get; set; }

    [JsonProperty ("ticktime")]
    public required int Ticktime { get; set; }

    public virtual BarsRoot HappyBar { get; set; } = default!;
    public int HappyBarID { get; set; }

    public virtual BarsRoot LifeBar { get; set; } = default!;
    public int LifeBarID { get; set; }

    public virtual BarsRoot EnergyBar { get; set; } = default!;
    public int EnergyBarID { get; set; }

    public virtual BarsRoot NerveBar { get; set; } = default!;
    public int NerveBarID { get; set; }
}
