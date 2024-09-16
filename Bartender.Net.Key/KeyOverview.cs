using Bartender.Net.Framework;

namespace Bartender.Net.Key;

public class KeyOverview : IBartenderEntity {
    public required int ID { get; set; }

    public required KeyInfo KeyInfo { get; set; }
}
