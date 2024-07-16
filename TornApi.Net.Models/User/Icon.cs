using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Icon {
    [JsonIgnore]
    public int ID { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}