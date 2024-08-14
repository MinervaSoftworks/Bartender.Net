using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionLoanable {
    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("type")]
    public string Type { get; set; }

    [JsonProperty ("quantity")]
    public int Quantity { get; set; }

    [JsonProperty ("available")]
    public int Available { get; set; }

    [JsonProperty ("loaned")]
    public int Loaned { get; set; }

    [JsonProperty ("loaned_to")]
    public string LoanedTo { get; set; }

    public List<int> LoanedToIDs {
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
