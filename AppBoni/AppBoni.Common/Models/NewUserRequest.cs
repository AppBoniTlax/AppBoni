using System;
using System.ComponentModel.DataAnnotations;

namespace AppBoni.Common.Models
{
    public class NewUserRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string SecondLastName { get; set; }

        [Required]
        public string Curp { get; set; }

        [Required]
        public DateTime BirthDateTime { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string NumExt { get; set; }

     
        public string NumInt { get; set; }

        [Required]
        public string Colony { get; set; }

        [Required]
        public string Cp { get; set; }

        [Required]
        public string Locality { get; set; }


        [Required]
        public long LocalityId { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public long BloodTypeId { get; set; }

        [Required]
        public string Height { get; set; }

        [Required]
        public string Weight { get; set; }


        [Required]
        public int Age { get; set; }

        [Required]
        public string Allergies { get; set; }


        [Required]
        public string FirstNameContact { get; set; }

        [Required]
        public string LastNameContact { get; set; }

        [Required]
        public string SecondLastNameContact { get; set; }

        [Required]
        public string PhoneContact { get; set; }


        [Required]
        public long RelationId { get; set; }

        [Required]
        public string AddressContact { get; set; }
    }
}
