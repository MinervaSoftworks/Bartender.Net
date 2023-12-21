using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TornApi.Net.Models.Common {
    public class ResponseError {
        [JsonProperty ("error")]
        public Error Error { get; set; }
    }

    public class Error {
        [JsonProperty ("code")]
        public int Code { get; set; } = -1;

        [JsonProperty ("error")]
        public string ErrorMsg { get; set; }
    }
}
