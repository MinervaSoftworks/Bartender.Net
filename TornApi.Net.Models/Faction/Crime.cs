using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class Crime {
    public Basic Faction { get; set; }

    public int CrimeID { get; set; }

    // IDK why you would call this crime_id and it actually mean the type of crime.
    [JsonProperty ("crime_id")]
    public int CrimeType { get; set; }

    [JsonProperty ("crime_name")]
    public string Name { get; set; }

    [JsonProperty ("initiated")]
    public bool Initiated { get; set; }

    [JsonProperty ("initiated_by")]
    public int InitiatedBy { get; set; }

    [JsonProperty ("money_gain")]
    public int MoneyGain { get; set; }

    [JsonProperty ("participants")]
    [JsonConverter(typeof(ParticipantConverter))]
    public IEnumerable<int> Participants { get; set; }

    [JsonProperty ("planned_by")]
    public int PlannedBy { get; set; }

    [JsonProperty ("respect_gain")]
    public int RespectGain { get; set; }

    [JsonProperty ("success")]
    public bool Success { get; set; }

    [JsonProperty ("time_completed")]
    public long TimeComplete { get; set; }

    [JsonProperty ("time_left")]
    public int TimeLeft { get; set; }

    [JsonProperty ("time_ready")]
    public long TimeReady { get; set; }

    [JsonProperty ("time_started")]
    public long TimeStarted { get; set; }

    private class ParticipantConverter : JsonConverter {
        public override bool CanConvert (Type objectType) {
            return true;
        }

        public override object ReadJson (JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            if (reader.TokenType != JsonToken.StartArray) {
                return null;
            }

            var participants = new List<int> ();

            while(reader.TokenType != JsonToken.EndArray) {
                reader.Read ();

                if(reader.TokenType == JsonToken.PropertyName) {
                    participants.Add (int.Parse(reader.Value as string));

                    reader.Skip ();
                }
            }

            return participants;
        }

        public override void WriteJson (JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException ("This shouldn't be used to write Json.");
        }
    }
}
