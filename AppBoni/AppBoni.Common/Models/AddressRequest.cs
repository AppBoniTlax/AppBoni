using System.ComponentModel.DataAnnotations;
using AppBoni.Entities;

namespace AppBoni.Common.Models
{
    public class AddressRequest : Address
    {
        [Required]
        public string Phone { get; set; }
    }
}
