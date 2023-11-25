namespace Torn.Api.Net.Models.User;

public class Bars {
    public ChainBar Chain { get; set; }

    public Bar Energy { get; set; }

    public Bar Happy { get; set; }

    public Bar Life { get; set; }

    public Bar Nerve { get; set; }

    public long ServerTime { get; set; }
}
