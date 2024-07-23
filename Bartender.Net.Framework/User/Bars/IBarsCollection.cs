namespace Bartender.Net.Framework.User.Bars;

public interface IBarsCollection {
    IBar Chain { get; set; }
    IBar Energy { get; set; }
    IBar Happy { get; set; }
    IBar Life { get; set; }
    IBar Nerve { get; set; }
    int ServerTime { get; set; }
}