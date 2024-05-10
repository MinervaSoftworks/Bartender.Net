using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TornApi.Net.Models.Faction;
using TornApi.Net.Models.Key;
using TornApi.Net.Models.Market;
using TornApi.Net.Models.User;
using TornApi.Net.REST;

internal class Program {
    private static void Main (string [] args) {
        Task.Run (async () => await ItemMarketTestAsync (args [0], args [1]));

        Console.ReadKey ();
    }

    private static async Task ItemMarketTestAsync (string url, string key) {
        var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, url);

        var requestConfig = new RequestConfiguration {
            Key = key,
            Section = "market",
            Selections = ["itemmarket"],
            Comment = "TornApi.Net market testing",
            ID = 4
        };

        var response = await client.GetAsync<ItemMarket> (requestConfig, AccessLevel.LimitedAccess);

        DisplayResponseState (response);
    }

    private static async Task BattleStatsFetchTestAsync (string url, string key) {
        var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, url);

        var requestConfig = new RequestConfiguration {
            Key = key,
            Section = "user",
            Selections = ["battlestats"],
            Comment = "DrunkSquad Battle Stats Fetch"
        };

        var response = await client.GetAsync<BattleStats> (requestConfig, AccessLevel.LimitedAccess);
    }

    private static async Task PointTestAsync (string url, string key) {
        var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, url);

        var config = new RequestConfiguration {
            Key = key,
            Section = "market",
            Selections = ["pointsmarket"],
            Comment = "TornApi.Net market testing",
        };

        var response = await client.GetAsync<PointMarket> (config, AccessLevel.PublicOnly);
    }

    private static async Task PositionsTestAsync (string url, string key) {
        var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, url);

        var config = new RequestConfiguration {
            Key = key,
            Section = "faction",
            Selections = ["positions"],
            Comment = "TornApi.Net market testing",
        };

        var response = await client.GetAsync<PositionsCollection> (config, TornApi.Net.Models.Key.AccessLevel.PublicOnly);
    }

    private static void DisplayResponseState<T> (IApiResponse<T>? response) => Console.WriteLine (response is not null && response.IsValid());
}