using System.Text;
using System.Net.Http.Headers;

using Newtonsoft.Json;

using Torn.Api.Net.Framework;
using Torn.Api.Net.Models.User;

namespace Torn.Api.Net.SendPostRequest
{
    internal class Program
    {
        
        static async Task Main()
        {
            //create and send a sample request
            TornAPI_Request request = new TornAPI_Request
            {
                apiKey = "rUOXxxcfsNe7nNJ3",
                section = "user",
                selections = ["basic", "publicstatus"]
            };
            
            await SendAPIRequest(request);
        }
        

        public static async Task SendAPIRequest(TornAPI_Request request)
        {
            using (var client = new HttpClient ())
            {
                Console.WriteLine("Constructing request...");
                client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));

                var _id =  request.userId != null ? request.userId : "";
                var _selections = $"&selections="; {for (int i = 0; i < request.selections.Length; i++){_selections = _selections + request.selections[i] + (i == request.selections.Length-1 ? "" : ",");}}
                var _key = $"&key={request.apiKey}";
                var _comment =  request.comment != null ? $"&comment={request.comment}" : "";

                //Format: https://api.torn.com/:SECTION/:ID?selections=:SELECTIONS&key=:KEY
                string url = "https://api.torn.com/";
                string _query = @$"{_id}?{_selections}{_key}{_comment}";
                
                client.BaseAddress = new Uri ($@"{url}{request.section}/");

                Console.WriteLine("Sending request: " + url + _query);
                var response = await client.GetAsync(_query);
                if(response.IsSuccessStatusCode) {
                    Console.WriteLine("Status code: " + response.StatusCode);
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Received data: {content}");
                    
                } else {
                    Console.WriteLine("ERROR: " + response.StatusCode);
                }
                
            }
        }
    }
}