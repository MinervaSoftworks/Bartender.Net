using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.JobPoints;

public class JobPointsCollection : BartenderEntity {
    [JsonProperty ("companies")]
    [NotMapped]
    public Dictionary<string, CompanyPoints> Companies {
        get => CompaniesList. ToTornDictionary();
        set => CompaniesList = value. TornDictionaryToList();
    }

    public virtual List<CompanyPoints> CompaniesList { get; set; } = [];

    [JsonProperty ("jobs")]
    public virtual required UserJobPoints JobPoints { get; set; }
}
