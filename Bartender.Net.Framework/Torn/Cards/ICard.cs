using Bartender.Net.Framework;

namespace Bartender.Net.Torn.Bank;

public interface ICard : IBartenderEntity {
    string Class { get; set; }
    string Name { get; set; }
    int Rank { get; set; }
    object Short { get; set; }
}
