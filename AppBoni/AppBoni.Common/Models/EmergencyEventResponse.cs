using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppBoni.Common.Models
{
    public class EmergencyEventResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("folio")]
        public string Folio { get; set; }

        [JsonProperty("dateEmergency")]
        public DateTime DateEmergency { get; set; }

        [JsonProperty("timeEmergency")]
        public TimeSpan TimeEmergency { get; set; }

        [JsonProperty("supervisorId")]
        public long SupervisorId { get; set; }

        [JsonProperty("attackType")]
        public string AttackType { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("folioC4")]
        public string FolioC4 { get; set; }

        [JsonProperty("estatus")]
        public long Estatus { get; set; }

        [JsonProperty("ubicacionActual")]
        public string UbicacionActual { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("edad")]
        public long Edad { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}
