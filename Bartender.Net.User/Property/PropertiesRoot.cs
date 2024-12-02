using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Property;

public class PropertiesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("properties")]
    [NotMapped]
    public Dictionary<string, UserProperty> Properties { get; set; } = default!;

    public virtual List<UserProperty> PropertiesList {
        get => Properties.TornDictionaryToList ();
        set => Properties = value.ToTornDictionary ();
    }
}
