namespace Bartender.Net.Framework.Common.News;

public interface INewsEntries {
    IDictionary<string, INewsEntry> News { get; }
}

