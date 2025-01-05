namespace Bartender.Net.Framework;

public abstract class BartenderEntity {
    public int ID { get; set; }

    public int TornID { get; set; }

    public long? FetchUTCTimeStamp { get; set; }
}
