using Bartender.Net.Framework.User.Networth;

namespace Bartender.Net.User.Networth;

public class UserNetworth : IUserNetworth {
    public INetworthRecord networthRecord { get; set; }
}