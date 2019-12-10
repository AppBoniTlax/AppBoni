using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppBoni.Common.Models
{
    public class UserResponse
    {
        [JsonProperty("document")] 
        public string Document { get; set; }

        [JsonProperty("firstName")] 
        public string FirstName { get; set; }

        [JsonProperty("lastName")] 
        public string LastName { get; set; }

        [JsonProperty("secondLastName")] 
        public string SecondLastName { get; set; }

        [JsonProperty("birthday")] 
        public DateTime Birthday { get; set; }

        [JsonProperty("email")] 
        public string Email { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }
}