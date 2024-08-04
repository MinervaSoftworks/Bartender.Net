using Bartender.Net.Framework;
using Bartender.Net.Framework.Selection;
using Bartender.Net.Framework.User.WeaponExp;
using Newtonsoft.Json;

namespace Bartender.Net.User.WeaponExp;

public class WeaponExpRoot : IWeaponExpRoot, ISelectionRoot {
    [JsonProperty ("weaponexp")]
    [JsonConverter (typeof(ConcreteConverter<WeaponExpEntry>))]
    public required IWeaponExpEntry WeaponExp { get; set; }

    public AccessLevel AccessLevelRequired => AccessLevel.Minimal;

    public string EndpointString => "weaponexp";

    public string Name => "Weapon Experience";
}
