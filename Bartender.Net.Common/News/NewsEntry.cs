namespace Bartender.Net.Framework.Common.News;

public class NewsEntry : INewsEntry {
    public string News { get; set; }
    public long Timestamp { get; set; }

    public int ID { get; set; }
}