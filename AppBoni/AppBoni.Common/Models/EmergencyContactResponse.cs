using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppBoni.Common.Models
{
    public class EmergencyContactResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("contactNumber")]
        public int ContactNumber { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("secondLastName")]
        public string SecondLastName { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("relationId")]
        public long RelationId { get; set; }
    }
}
