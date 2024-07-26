﻿using Bartender.Net.Framework.Market.PointsMarket;
using Newtonsoft.Json;

namespace TornApi.Net.Models.Market;

public class PointListings : IPointListings {
    [JsonProperty ("pointsmarket")]
    public required IDictionary<string, IPointListing> Points { get; set; }
}