using Bartender.Net.Framework.User.Networth;

namespace Bartender.Net.User.Networth;

public class UserNetworth : IUserNetworth {
    public required INetworthRecord networthRecord { get; set; }
}