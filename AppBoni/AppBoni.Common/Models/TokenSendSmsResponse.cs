using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppBoni.Common.Models
{
    public class TokenSendSmsResponse
    {
        [JsonProperty("success")] 
        public bool Success { get; set; }

        [JsonProperty("message")] 
        public string Message { get; set; }

        [JsonProperty("status")] 
        public long Status { get; set; }

        [JsonProperty("code")] 
        public string Code { get; set; }

        [JsonProperty("references")] 
        public Reference[] References { get; set; }
    }

    public class Reference
    {
        [JsonProperty("reference")] 
        public string ReferenceReference { get; set; }

        [JsonProperty("number")] 
        public long Number { get; set; }
    }
}