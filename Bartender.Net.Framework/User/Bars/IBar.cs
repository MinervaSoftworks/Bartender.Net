namespace Bartender.Net.Framework.User.Bars;

public interface IBar : IBartenderEntity {
    int Current { get; }
    int Fulltime { get; }
    int Increment { get; }
    int Interval { get; }
    int Maximum { get; }
    int Ticktime { get; }
}