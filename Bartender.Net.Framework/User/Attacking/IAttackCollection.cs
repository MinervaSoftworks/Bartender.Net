namespace Bartender.Net.Framework.User.Attacking;

public interface IAttackCollection {
    IDictionary<string, IAttack> Attacks { get; }
}