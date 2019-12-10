using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppBoni.Common.Models
{
    public class MunicipalitiyResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }

    }

}
