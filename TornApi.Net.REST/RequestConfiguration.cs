using System.Diagnostics.CodeAnalysis;

namespace TornApi.Net.REST {
    public struct RequestConfiguration {
        [NotNull]
        public string Key { get; set; }

        public int ID { get; set; }

        public string? Comment { get; set; }

        [NotNull]
        public string Section { get; set; }

        [NotNull]
        public IEnumerable<string> Selections { get; set; }

        public int? From { get; set; }

        public int? To { get; set; }

        public int? Limit { get; set; }

        public string? Sort { get; set; }

        public override string ToString () {
            var keyPart = $"&key={Key}";

            var selectionPart = $"?selections={string.Join (',', Selections)}";

            var commentPart = Comment is not null && Comment.Length > 0 ? $"&comment={Comment}" : "";

            var fromPart = From  > 0 ? $"&from={From}" : "";

            var toPart = To > 0 ? $"&to={To}" : "";

            var limitPart = Limit > 0 ? $"&={Limit}" : "";

            var sortPart = Sort is not null && Sort.Length > 0 ? $"&sort={Sort}" : "";

            return $"/{Section}/{ID}{selectionPart}{commentPart}{fromPart}{toPart}{sortPart}{keyPart}";
        }
    }
}
