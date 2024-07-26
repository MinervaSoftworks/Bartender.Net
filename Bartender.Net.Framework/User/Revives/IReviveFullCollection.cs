namespace Bartender.Net.Framework.User.Revives;

public interface IReviveFullCollection {
    IDictionary<string, IReviveFull> Revives { get; }
}