namespace Bartender.Net.Framework.Sections;

public record Section (string Name, IEnumerable<Selection> Selections);
