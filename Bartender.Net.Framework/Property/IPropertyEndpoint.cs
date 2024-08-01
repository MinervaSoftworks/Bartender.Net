using Bartender.Net.Framework.User.Property;

namespace Bartender.Net.Framework.Property;

public interface IPropertyEndpoint {
    IUserProperty Property { get; }
}