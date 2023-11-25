namespace Torn.Api.Net.Models.Faction;

public class Armor {
    public int Available { get; set; }

    public int ID { get; set; }

    public int Loaned { get; set; }

    public string LoanedTo { get; set; }

    public string Name { get; set; }

    public int Quantity { get; set; }

    public string Type { get; set; }
}
