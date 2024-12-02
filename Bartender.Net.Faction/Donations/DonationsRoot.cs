using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Donations;

public class DonationsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("donations")]
    [NotMapped]
    public Dictionary<string, DonationEntry> Donations { get; set; } = default!;

    public virtual List<DonationEntry> DonationsList {
        get => Donations.TornDictionaryToList ();
        set => Donations = value.ToTornDictionary ();
    }
}