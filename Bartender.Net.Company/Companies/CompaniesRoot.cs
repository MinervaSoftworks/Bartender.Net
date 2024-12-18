using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Companies;

public class CompaniesRoot : BartenderEntity {
    [JsonProperty ("cards")]
    public Dictionary<string, CompanyEntry> Companies { get; set; } = default!;

    public virtual List<CompanyEntry> CompaniesList {
        get => Companies.TornDictionaryToList ();
        set => Companies = value.ToTornDictionary ();
    }
}
