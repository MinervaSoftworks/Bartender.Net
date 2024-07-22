using Newtonsoft.Json;
using TornApi.Net.Models.Common.Extensions;

namespace TornApi.Net.Models.Key;

public class KeyInfo {
    [JsonProperty ("access_level")]
    public int AccessLevel { get; set; }

    [JsonProperty ("access_type")]
    [JsonConverter (typeof (AccessLevelConverter))]
    public AccessLevel AccessType { get; set; }

    [JsonProperty ("selections")]
    public Selections Selections { get; set; }

    private class AccessLevelConverter : JsonConverter {
        public override bool CanConvert (Type objectType) => objectType == typeof (string);

        public override object ReadJson (JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            var value = reader.Value.ToString ();
            return value.ToAccessLevel (); ;
        }

        public override void WriteJson (JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException ("I'll get to this before it hits production :)");
        }
    }
}
