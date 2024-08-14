﻿using Newtonsoft.Json;

namespace Bartender.Net.Company.News;

public class CompanyNewsEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("news")]
    public string News { get; set; }

    [JsonProperty ("timestamp")]
    public int Timestamp { get; set; }
}
