using TornApi.Net.Models.Common;

namespace TornApi.Net.Models.Faction;

public class CrimeParticipants {
    public IDictionary<int, Status> Participants { get; set; }
}
