using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Donations;

public class DonationsRoot : BartenderEntity {
    [JsonProperty ("donations")]
    [NotMapped]
    public Dictionary<string, DonationEntry> Donations {
        get => DonationsList.ToTornDictionary ();
        set => DonationsList = value.TornDictionaryToList ();
    }

    public virtual List<DonationEntry> DonationsList { get; set; } = [];
}