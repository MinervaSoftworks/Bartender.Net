using Bartender.Net.Framework.Selection;

namespace Bartender.Net.User;

public class UserSection : ISection {
    public string EndpointString => "user";

    public string Name => "User";

    public IEnumerable<ISelectionRoot> Selections => throw new NotImplementedException();
}