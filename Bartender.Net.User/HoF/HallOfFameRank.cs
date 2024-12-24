using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.HoF;

public class HallOfFameRank : BartenderEntity {
    [JsonProperty ("value")]
    public required int Value { get; set; }

    [JsonProperty ("rank")]
    public required int Rank { get; set; }

    public virtual HallOfFameRoot HOFAttacks { get; set; } = default!;

    public virtual HallOfFameRoot HOFBattlestats { get; set; } = default!;

    public virtual HallOfFameRoot HOFBusts { get; set; } = default!;

    public virtual HallOfFameRoot HOFDefends { get; set; } = default!;

    public virtual HallOfFameRoot HOFNetworth { get; set; } = default!;

    public virtual HallOfFameRoot HOFOffences { get; set; } = default!;

    public virtual HallOfFameRoot HOFRevives { get; set; } = default!;

    public virtual HallOfFameRoot HOFTraveltime { get; set; } = default!;

    public virtual HallOfFameRoot HOFWorkstats { get; set; } = default!;

    public virtual HallOfFameRoot HOFLevel { get; set; } = default!;

    public virtual HallOfFameRoot HOFRank { get; set; } = default!;

    public virtual HallOfFameRoot HOFAwards { get; set; } = default!;
}

