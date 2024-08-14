﻿using Newtonsoft.Json;

namespace Bartender.Net.Common.Reports;

public class Warrant {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("user_id")]
    public int UserID { get; set; }

    [JsonProperty ("warrant")]
    public int Amount { get; set; }
}
