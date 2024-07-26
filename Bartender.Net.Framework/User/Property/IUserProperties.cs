namespace Bartender.Net.Framework.User.Property;

public interface IUserProperties {
    IDictionary<string, IUserProperty> Properties { get; }
}