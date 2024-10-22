﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Companies;

public class CompaniesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("cards")]
    public required Dictionary<string, CompanyEntry> Companies { get; set; }
}
