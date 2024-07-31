namespace Bartender.Net.Framework.Common.Revives;

public interface IReviveFullCollection {
    IDictionary<string, IReviveFull> Revives { get; }
}