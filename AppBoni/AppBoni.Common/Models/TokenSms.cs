using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppBoni.Common.Models
{
    public class TokenSms
    {
        [JsonProperty("success")] 
        public bool Success { get; set; }

        [JsonProperty("message")] 
        public string Message { get; set; }

        [JsonProperty("status")] 
        public long Status { get; set; }

        [JsonProperty("code")] 
        public string Code { get; set; }

        [JsonProperty("token")] 
        public string Token { get; set; }

        [JsonProperty("email")] 
        public string Email { get; set; }
    }
}