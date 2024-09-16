using Bartender.Net.Framework;
using Bartender.Net.Property.Property;

namespace Bartender.Net.Property;

public class PropertyOverview : IBartenderEntity {
    public required int ID { get; set; }

    public required PropertyRoot Property { get; set; }
}
