using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.JobPoints;

public class JobPointsCollection : BartenderEntity {
    [JsonProperty ("companies")]
    [NotMapped]
    public Dictionary<string, CompanyPoints> Companies { get; set; } = default!;

    public virtual List<CompanyPoints> CompaniesList {
        get => Companies.TornDictionaryToList ();
        set => Companies = value.ToTornDictionary ();
    }

    [JsonProperty ("jobs")]
    public virtual required UserJobPoints JobPoints { get; set; }
}
