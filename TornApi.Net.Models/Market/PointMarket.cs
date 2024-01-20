using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TornApi.Net.Models.Market;

public class PointMarket {
    [JsonProperty ("pointsmarket")]
    public IDictionary<int, Point> Points { get; set; }

    public class PointsmarketConvertor : JsonConverter {
        public override bool CanConvert (Type objectType) => true;

        public override object ReadJson (JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            var jObject = new JObject (reader);
            var pointsmarket = jObject.First;
            var points = new Dictionary<string, Point> ();

            foreach (var point in pointsmarket.Children()) {
                var parent = ((JProperty) point.Parent);

                var id = parent.Name;
                var value = parent.Value<Point>();

                points.Add (id, value);
            }

            return points;
        }

        public override void WriteJson (JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException ();
        }
    }
}
