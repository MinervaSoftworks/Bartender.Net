using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Company.Applications;

public class CompanyApplicationsRoot : BartenderEntity {
    [JsonProperty ("applications")]
    [NotMapped]
    public Dictionary<string, CompanyApplication> Applications {
        get => ApplicationsList.ToTornDictionary ();
        set => ApplicationsList = value.TornDictionaryToList ();
    }

    public virtual List<CompanyApplication> ApplicationsList { get; set; } = default!;
}
