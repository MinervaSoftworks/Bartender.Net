using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Property;

public class PropertiesRoot : BartenderEntity {
    [JsonProperty ("properties")]
    [NotMapped]
    public Dictionary<string, UserProperty> Properties {
        get => PropertiesList.ToTornDictionary ();
        set => PropertiesList = value.TornDictionaryToList ();
    }

    public virtual List<UserProperty> PropertiesList { get; set; } = [];
}
