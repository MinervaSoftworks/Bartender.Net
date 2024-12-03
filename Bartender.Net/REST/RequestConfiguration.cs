using Bartender.Net.Framework.REST;
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.REST;

public class RequestConfiguration : IRequestConfiguration {
    public required string Key { get; set; }

    public int ID { get; set; }

    public string? Comment { get; set; }

    public required string Section { get; set; }

    public required List<Selection> Selections { get; set; }

    public DateTime? From { get; set; }

    public DateTime? To { get; set; }

    public int? Limit { get; set; }

    public string? Sort { get; set; }

    public override string ToString () {
        var idPart = ID > 0 ? $"{ID}" : "";

        var keyPart = $"&key={Key}";

        var selectionPart = $"?selections={string.Join (',', Selections.Select(s => s.Name))}";

        var commentPart = Comment is not null && Comment.Length > 0 ? $"&comment={Comment}" : "";

        var fromPart = From is not null ? $"&from={GetUnixTimestamp (From.Value)}" : "";

        var toPart = To is not null ? $"&to={GetUnixTimestamp (To.Value)}" : "";

        var limitPart = Limit > 0 ? $"&limit={Limit}" : "";

        var sortPart = Sort is not null && Sort.Length > 0 ? $"&sort={Sort}" : "";

        return $"/{Section}/{idPart}{selectionPart}{commentPart}{fromPart}{toPart}{limitPart}{sortPart}{keyPart}";
    }

    private static long GetUnixTimestamp (DateTime dateTime) {
        DateTime unixEpoch = new DateTime (1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        TimeSpan timeDifference = dateTime.ToUniversalTime () - unixEpoch;

        return (long) timeDifference.TotalSeconds;
    }
}
