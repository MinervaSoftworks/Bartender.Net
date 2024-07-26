namespace Bartender.Net.Framework.User.Bars;

public interface IBarsCollection {
    IBar Chain { get; }
    IBar Energy { get; }
    IBar Happy { get; }
    IBar Life { get; }
    IBar Nerve { get; }
    int ServerTime { get; }
}