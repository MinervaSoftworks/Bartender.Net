using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TornApi.Net.Models.Faction;
using TornApi.Net.Models.Key;
using TornApi.Net.Models.Market;
using TornApi.Net.Models.User;
using TornApi.Net.REST;

internal class Program {
    private static void Main (string [] args) {
        //Task.Run (async () => await ItemMarketTestAsync (args [0], args [1]));
        //Task.Run (async () => await CurrentChainTestAsync (args [0], args [1]));
        //Task.Run (async () => await ChainOverviewTestAsync (args [0], args [1]));
        //Task.Run (async () => await ChainHistoryTestAsync(args [0], args [1]));

        Console.ReadKey ();
    }

    private static async Task ChainHistoryTestAsync (string url, string key) {
        var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, url);

        var requestConfig = new RequestConfiguration {
            Key = key,
            Section = "faction",
            Selections = ["chains"],
            Comment = "TornApi.Net chain history testing"
        };

        var response = await client.GetAsync<ChainHistory> (requestConfig, AccessLevel.LimitedAccess);

        DisplayResponseState (response);

        if(response is null || response.HttpResponseMessage is null) {
            return;
        }

        Console.WriteLine (JToken.Parse (await response.HttpResponseMessage.Content.ReadAsStringAsync ()).ToString (Formatting.Indented));
    }

    private static async Task ChainOverviewTestAsync (string url, string key) {
        var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, url);

        var requestConfig = new RequestConfiguration {
            Key = key,
            Section = "faction",
            Selections = ["chainreport"],
            Comment = "TornApi.Net chain report testing"
        };

        var response = await client.GetAsync<FactionChainOverview> (requestConfig, AccessLevel.LimitedAccess);

        DisplayResponseState (response);

        if (response is null || response.HttpResponseMessage is null) {
            return;
        }

        Console.WriteLine (JToken.Parse (await response.HttpResponseMessage.Content.ReadAsStringAsync ()).ToString (Formatting.Indented));
    }

    private static async Task CurrentChainTestAsync (string url, string key) {
        var client = new ApiRequestClient (DefaultApiRequestClientFactory.Instance, url);

        var requestConfig = new RequestConfiguration {
            Key = key,
            Section = "faction",
            Selections = ["chain"],
            Comment = "TornApi.Net current chain testing"
        };

        var response = await client.GetAsync<CurrentChain> (requestConfig, AccessLevel.LimitedAccess);

        DisplayResponseState (response);

        if (response is null || response.HttpResponseMessage is null) {
            return;
        }

        Console.WriteLine (JToken.Parse (await response.HttpResponseMessage.Content.ReadAsStringAsync ()).ToString (Formatting.Indented));
    }
    
    private static void DisplayResponseState<T> (IApiResponse<T>? response) => Console.WriteLine (response is not null && response.IsValid());
}