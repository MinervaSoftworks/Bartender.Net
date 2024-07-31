using Bartender.Net.Framework.Common.User;

namespace Bartender.Net.Framework.User.Profile;

public interface IRelativeLastAction : ILastAction {
    string Relative { get; }
}