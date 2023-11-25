using Torn.Api.Net.Framework;

namespace Torn.Api.Net.Models;

public class Selection (int id, string name, int section, AccessLevel accessLevel) : ISelection {
    public int ID => id;

    public string Name => name;

    public int Section => section;

    public AccessLevel AccessLevel => accessLevel;
}
