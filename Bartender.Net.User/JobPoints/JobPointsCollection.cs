﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class JobPointsCollection : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("companies")]
    public required Dictionary<string, CompanyPoints> Companies { get; set; }

    [JsonProperty ("jobs")]
    public virtual required UserJobPoints JobPoints { get; set; }
}
