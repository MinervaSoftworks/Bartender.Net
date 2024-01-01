namespace TornApi.Net.REST {
    public struct RequestConfiguration : IRequestConfiguration {
        public string Key { get; set; }

        public int ID { get; set; }

        public string? Comment { get; set; }

        public string Section { get; set; }

        public IEnumerable<string> Selections { get; set; }

        public DateTime? From { get; set; }

        public DateTime? To { get; set; }

        public int? Limit { get; set; }

        public string? Sort { get; set; }

        public override string ToString () {
            var keyPart = $"&key={Key}";

            var selectionPart = $"?selections={string.Join (',', Selections)}";

            var commentPart = Comment is not null && Comment.Length > 0 ? $"&comment={Comment}" : "";

            var fromPart = From is not null ? $"&from={GetUnixTimestamp (From.Value)}" : "";

            var toPart = To is not null ? $"&to={GetUnixTimestamp (To.Value)}" : "";

            var limitPart = Limit > 0 ? $"&={Limit}" : "";

            var sortPart = Sort is not null && Sort.Length > 0 ? $"&sort={Sort}" : "";

            return $"/{Section}/{ID}{selectionPart}{commentPart}{fromPart}{toPart}{limitPart}{sortPart}{keyPart}";
        }

        private static long GetUnixTimestamp (DateTime dateTime) {
            DateTime unixEpoch = new DateTime (1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan timeDifference = dateTime.ToUniversalTime () - unixEpoch;

            return (long) timeDifference.TotalSeconds;
        }
    }
}
