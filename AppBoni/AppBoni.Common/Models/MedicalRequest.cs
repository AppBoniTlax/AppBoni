using System.ComponentModel.DataAnnotations;
using AppBoni.Entities;

namespace AppBoni.Common.Models
{
    public class MedicalRequest : Medical
    {
        [Required]
        public string Phone { get; set; }
    }
}
