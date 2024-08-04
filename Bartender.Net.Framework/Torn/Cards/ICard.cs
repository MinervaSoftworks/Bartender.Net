using Bartender.Net.Framework;

namespace Bartender.Net.Torn.Bank;

public interface ICard : IBartenderEntity {
    string Class { get; }
    string Name { get; }
    int Rank { get; }
    object Short { get; }
}
