using System.ComponentModel.DataAnnotations;
using AppBoni.Entities;

namespace AppBoni.Common.Models
{
    public class EmergencyContactRequest 
    {
        public long Id { get; set; }

        [Required]
        public int ContactNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string SecondLastName { get; set; }

        [Required]
        public string Telephone { get; set; }

        [Required]
        public long RelationId { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}

 