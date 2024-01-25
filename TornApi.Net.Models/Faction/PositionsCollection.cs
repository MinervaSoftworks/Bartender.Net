using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TornApi.Net.Models.Faction;

public class PositionsCollection {
    [JsonProperty ("positions")]
    [JsonConverter (typeof(PositionsConverter))]
    public IEnumerable<Position> Positions { get; set; }

    private class PositionsConverter : JsonConverter {
        public override bool CanConvert (Type objectType) {
            throw new NotImplementedException ();
        }

        public override object ReadJson (JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            var jObj = JObject.Load (reader);

            var positions = new List<Position> ();

            foreach (var property in jObj.Properties ()) {
                var position = property.Value.ToObject<Position> ();
                position.Name = property.Name;

                positions.Add (position);
            }

            return positions;
        }

        public override void WriteJson (JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException ();
        }
    }
}
