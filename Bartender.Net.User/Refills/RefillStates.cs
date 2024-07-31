using Bartender.Net.Framework.User.Refills;
using Newtonsoft.Json;

namespace Bartender.Net.User.Refills;

public class RefillStates : IRefillStates {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("energy_refill_used")]
    public bool EnergyRefillUsed { get; set; }

    [JsonProperty ("nerve_refill_used")]
    public bool NerveRefillUsed { get; set; }

    [JsonProperty ("token_refill_used")]
    public bool TokenRefillUsed { get; set; }

    [JsonProperty ("special_refills_available")]
    public int SpecialRefillsAvailable { get; set; }
}
