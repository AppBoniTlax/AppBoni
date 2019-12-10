using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppBoni.Common.Models
{
    public class MedicalResponse
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("bloodTypeId")] public long BloodTypeId { get; set; }

        [JsonProperty("height")] public string Height { get; set; }

        [JsonProperty("weight")] public string Weight { get; set; }

        [JsonProperty("age")] public int Age { get; set; }

        [JsonProperty("allergies")] public string Allergies { get; set; }

        [JsonProperty("estatus")] public int Estatus { get; set; }

        [JsonProperty("active")] public bool Active { get; set; }

       
    }
}
