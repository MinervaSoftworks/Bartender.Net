namespace Bartender.Net.Framework.User.Bars;

public interface IBar : IBartenderEntity {
    int Current { get; set; }
    int Fulltime { get; set; }
    int Increment { get; set; }
    int Interval { get; set; }
    int Maximum { get; set; }
    int Ticktime { get; set; }
}