using Newtonsoft.Json;

namespace AppBoni.Common.Models
{
    public class AddressResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("numInt")]
        public string NumInt { get; set; }

        [JsonProperty("numExt")]
        public string NumExt { get; set; }

        [JsonProperty("colony")]
        public string Colony { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("municipioId")]
        public long MunicipioId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("estatus")]
        public int Estatus { get; set; }

        [JsonProperty("cp")]
        public string Cp { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}