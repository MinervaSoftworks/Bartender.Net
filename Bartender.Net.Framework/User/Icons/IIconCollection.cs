namespace Bartender.Net.Framework.User.Icons;

public interface IIconCollection : IBartenderEntity {
    IDictionary<string, string> Icons { get; }
}