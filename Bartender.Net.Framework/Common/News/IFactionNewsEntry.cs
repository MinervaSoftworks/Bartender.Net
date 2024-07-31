namespace Bartender.Net.Framework.Common.News;

public interface IFactionNewsEntry : IBartenderEntity
{
    string News { get; set; }
    long Timestamp { get; set; }
}