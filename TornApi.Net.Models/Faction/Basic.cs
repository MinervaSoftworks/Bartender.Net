using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace TornApi.Net.Models.Faction;

public class Basic {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("age")]
    public int Age { get; set; }

    [JsonProperty ("best_chain")]
    public int BestChain { get; set; }

    [JsonProperty ("capacity")]
    public int Capacity { get; set; }

    [JsonProperty ("co-leader")]
    public int ColeaderID { get; set; }

    [JsonProperty ("ID")]
    public int FactionID { get; set; }

    [JsonProperty ("leader")]
    public int LeaderID { get; set; }

    [JsonProperty ("members")]
    [JsonConverter(typeof(MembersConverter))]
    public IEnumerable<Member> Members { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty("peace")]
    public IDictionary<string, long> PeaceTreaties { get; set; }

    [JsonProperty("raid_wars")]
    public IDictionary<string, Raid> RaidWars { get; set; }

    [JsonProperty ("rank")]
    public Ranking Rank { get; set; }

    [JsonProperty("ranked_wars")]
    public IDictionary<string, RankedWar> RankedWars { get; set; }

    [JsonProperty ("respect")]
    public int Respect { get; set; }

    [JsonProperty ("tag")]
    public string Tag { get; set; }

    [JsonProperty ("tag_image")]
    public string TagImage { get; set; }

    [JsonProperty("territory_wars")]
    public IEnumerable<TerritoryWar> TerritoryWars { get; set; }

    private class MembersConverter : JsonConverter {
        public override bool CanConvert(Type objectType) => false;

        public override object ReadJson (JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            // I have learned that I can turn a JsonReader into a JObject.
            var jObj = JObject.Load (reader);

            var members = new List<Member> ();

            foreach (var property in jObj.Properties()) {
                var id = property.Name;
                var member = property.Value.ToObject<Member> ();

                member.ProfileID = int.Parse(id);

                members.Add (member);
            }

            return members;
        }

        public override void WriteJson (JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException ();
        }
    }
}
