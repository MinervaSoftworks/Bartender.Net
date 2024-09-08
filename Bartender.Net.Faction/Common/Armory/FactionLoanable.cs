using Newtonsoft.Json;

namespace Bartender.Net.Faction.Common.Armory;

public class FactionLoanable {
    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("type")]
    public required string Type { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("available")]
    public required int Available { get; set; }

    [JsonProperty ("loaned")]
    public required int Loaned { get; set; }

    [JsonProperty ("loaned_to")]
    public required string LoanedTo { get; set; }

    public required List<int> LoanedToIDs {
        get {
            if (LoanedTo.Length > 0 && !_loanedIDs.Any ()) {
                var ids = new List<int> ();

                foreach (var id in LoanedTo.Split (',')) {
                    ids.Add (int.Parse (id));
                }

                _loanedIDs = ids;
            }

            return _loanedIDs;
        }
        set => _loanedIDs = value;
    }

    private List<int> _loanedIDs = new List<int> ();
}
