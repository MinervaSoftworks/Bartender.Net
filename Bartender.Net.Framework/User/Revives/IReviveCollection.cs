namespace Bartender.Net.Framework.User.Revives;

public interface IReviveCollection {
    IDictionary<string, IRevive> Revives { get; set; }
}