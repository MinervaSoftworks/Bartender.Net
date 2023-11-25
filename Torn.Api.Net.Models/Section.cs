using Torn.Api.Net.Framework;

namespace Torn.Api.Net.Models;

public class Section (int id, string name, IEnumerable<ISelection> selections) : ISection {
    public int ID => id;

    public string Name => name;

    public IEnumerable<ISelection> Selections => selections;
}
