using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Company.Applications;

public class CompanyApplicationsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("applications")]
    [NotMapped]
    public Dictionary<string, CompanyApplication> Applications { get; set; } = default!;

    public virtual List<CompanyApplication> ApplicationsList {
        get => Applications.TornDictionaryToList ();
        set => Applications = value.ToTornDictionary ();
    }
}
