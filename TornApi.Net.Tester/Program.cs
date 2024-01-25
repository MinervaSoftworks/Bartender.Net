using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TornApi.Net.Models.Faction;
using TornApi.Net.Models.Market;
using TornApi.Net.REST;

internal class Program {
    private static void Main (string [] args) {
        Task.Run (async () => await PositionsTest (args [0], args [1]));

        Console.ReadKey ();
    }

    private static async Task PointTest (string url, string key) {
        var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, url);

        var config = new RequestConfiguration {
            Key = key,
            Section = "market",
            Selections = ["pointsmarket"],
            Comment = "TornApi.Net market testing",
        };

        var response = await client.GetAsync<PointMarket> (config, TornApi.Net.Models.Key.AccessLevel.PublicOnly);

        Console.WriteLine(response);
    }

    private static async Task PositionsTest (string url, string key) {
        var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, url);

        var config = new RequestConfiguration {
            Key = key,
            Section = "faction",
            Selections = ["positions"],
            Comment = "TornApi.Net market testing",
        };

        var response = await client.GetAsync<PositionsCollection> (config, TornApi.Net.Models.Key.AccessLevel.PublicOnly);

        Console.WriteLine (response);
    }
}