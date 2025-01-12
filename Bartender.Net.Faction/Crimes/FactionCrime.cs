using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Crimes;

public class FactionCrime : BartenderEntity {
    [JsonProperty ("crime_id")]
    public required int CrimeType { get; set; }

    [JsonProperty ("crime_name")]
    public required string Name { get; set; }

    [JsonProperty ("initiated")]
    public required bool Initiated { get; set; }

    [JsonProperty ("initiated_by")]
    public required int InitiatedBy { get; set; }

    [JsonProperty ("money_gain")]
    public required int MoneyGain { get; set; }

    [JsonProperty ("participants")]
    [JsonConverter (typeof (ParticipantConverter))]
    public List<int> Participants { get; set; } = [];

    [JsonProperty ("planned_by")]
    public required int PlannedBy { get; set; }

    [JsonProperty ("respect_gain")]
    public required int RespectGain { get; set; }

    [JsonProperty ("success")]
    public bool Success { get; set; }

    [JsonProperty ("time_completed")]
    public required long TimeComplete { get; set; }

    [JsonProperty ("time_left")]
    public required int TimeLeft { get; set; }

    [JsonProperty ("time_ready")]
    public required long TimeReady { get; set; }

    [JsonProperty ("time_started")]
    public required long TimeStarted { get; set; }

    private class ParticipantConverter : JsonConverter {
        public override bool CanConvert (Type objectType) {
            return true;
        }

        public override object? ReadJson (JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer) {
            if (reader.TokenType != JsonToken.StartArray) {
                return null;
            }

            var participants = new List<int> ();

            while (reader.TokenType != JsonToken.EndArray) {
                reader.Read ();

                if (reader.TokenType == JsonToken.PropertyName && reader.Value is string id) {
                    participants.Add (int.Parse (id));

                    reader.Skip ();
                }
            }

            return participants;
        }

        public override void WriteJson (JsonWriter writer, object? value, JsonSerializer serializer) {
            if (value == null) {
                writer.WriteStartArray ();
                writer.WriteEndArray ();
                return;
            }

            var participants = (IEnumerable<int>) value;

            writer.WriteStartArray ();

            foreach (var participant in participants) {
                writer.WriteValue (participant);
            }

            writer.WriteEndArray ();
        }
    }
}
