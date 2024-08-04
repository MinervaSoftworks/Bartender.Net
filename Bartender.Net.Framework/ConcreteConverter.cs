using Newtonsoft.Json;

namespace Bartender.Net.Framework;

public class ConcreteConverter<T> : JsonConverter {
    public override bool CanConvert (Type objectType) => objectType == typeof (T);

    public override object? ReadJson (JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer) => CanConvert (objectType) ? serializer.Deserialize<T> (reader) : null;

    public override void WriteJson (JsonWriter writer, object? value, JsonSerializer serializer) => serializer.Serialize (writer, value);
}
