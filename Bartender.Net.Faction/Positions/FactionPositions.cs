using Newtonsoft.Json;

namespace Bartender.Net.Faction.Positions;

public class FactionPositions : IFactionPositions {
    [JsonProperty ("positions")]
    public IDictionary<string, IFactionPosition> Positions {
        get => _positions;

        set {
            foreach (var key in value.Keys) {
                value [key].Name = key;
            }

            _positions = value;
        }
    }

    private IDictionary<string, IFactionPosition> _positions = new Dictionary<string, IFactionPosition> ();
}
