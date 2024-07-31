namespace Bartender.Net.Framework.Common.News;

public interface INewsEntry : IBartenderEntity {
    string News { get; set; }
    long Timestamp { get; set; }
}
