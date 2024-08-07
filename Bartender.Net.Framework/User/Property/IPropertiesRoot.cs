using Bartender.Net.Framework.User.Property;

namespace Bartender.Net.User.Property;

public interface IPropertiesRoot {
    IDictionary<string, IUserProperty> Properties { get; set; }
}
