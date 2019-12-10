using Newtonsoft.Json;

namespace AppBoni.Common.Models
{
    public class Relationship
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("estatus")]
        public long Estatus { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}
