using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Company.Applications;

public class CompanyApplicationsRoot : BartenderEntity {
    [JsonProperty ("applications")]
    [NotMapped]
    public Dictionary<string, CompanyApplication> Applications { get; set; } = default!;

    public virtual List<CompanyApplication> ApplicationsList {
        get => Applications.TornDictionaryToList ();
        set => Applications = value.ToTornDictionary ();
    }
}
