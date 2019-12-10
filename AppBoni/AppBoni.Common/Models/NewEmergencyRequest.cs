using System.ComponentModel.DataAnnotations;

namespace AppBoni.Common.Models
{
    public class NewEmergencyRequest
    {
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Ubication { get; set; }

    }
}
