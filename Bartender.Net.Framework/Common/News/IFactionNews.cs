namespace Bartender.Net.Framework.Common.News;

public interface IFactionNews
{
    IDictionary<string, IFactionNewsEntry> News { get; set; }
}
