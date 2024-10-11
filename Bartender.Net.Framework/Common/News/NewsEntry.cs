namespace Bartender.Net.Framework.Common.News;

public class NewsEntry : BartenderEntity {
    public required string News { get; set; }

    public required long Timestamp { get; set; }

    public override int ID { get; set; }
}