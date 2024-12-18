using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.HoF;

public class HallOfFameRank : BartenderEntity {
    [JsonProperty ("value")]
    public required int Value { get; set; }

    [JsonProperty ("rank")]
    public required int Rank { get; set; }

    public HallOfFameRoot HOFAttacks { get; set; } = default!;

    public HallOfFameRoot HOFBattlestats { get; set; } = default!;

    public HallOfFameRoot HOFBusts { get; set; } = default!;

    public HallOfFameRoot HOFDefends { get; set; } = default!;

    public HallOfFameRoot HOFNetworth { get; set; } = default!;

    public HallOfFameRoot HOFOffences { get; set; } = default!;

    public HallOfFameRoot HOFRevives { get; set; } = default!;

    public HallOfFameRoot HOFTraveltime { get; set; } = default!;

    public HallOfFameRoot HOFWorkstats { get; set; } = default!;

    public HallOfFameRoot HOFLevel { get; set; } = default!;

    public HallOfFameRoot HOFRank { get; set; } = default!;

    public HallOfFameRoot HOFAwards { get; set; } = default!;
}

