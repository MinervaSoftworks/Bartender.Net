namespace Bartender.Net.Framework.User.Attacking;

public interface IAttackStubCollection {
    IDictionary<string, IAttackStub> Attacks { get; }
}