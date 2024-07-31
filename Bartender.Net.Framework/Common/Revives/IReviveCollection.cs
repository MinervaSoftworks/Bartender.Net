namespace Bartender.Net.Framework.Common.Revives;

public interface IReviveCollection {
    IDictionary<string, IRevive> Revives { get; }
}