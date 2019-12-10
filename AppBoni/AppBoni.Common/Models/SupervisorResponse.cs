using System;
using AppBoni.Entities;
using Newtonsoft.Json;

namespace AppBoni.Common.Models
{
    public class SupervisorResponse
    {
        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("secondLastName")]
        public string SecondLastName { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("birthday")]
        public DateTimeOffset Birthday { get; set; }
        
        [JsonProperty("fullName")] 
        public string FullName { get; set; }

        [JsonProperty("fullNameWithDocument")] 
        public string FullNameWithDocument { get; set; }

        [JsonProperty("phoneNumber")]
        public string Phone { get; set; }

        [JsonProperty("userName")] 
        public string UserName { get; set; }

        [JsonProperty("email")] 
        public string Email { get; set; }
    }
}

