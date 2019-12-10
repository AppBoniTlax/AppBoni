using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppBoni.Common.Models
{
    public class UserRequest
    {
        [Required]
        public string Document { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string SecondLastName { get; set; }
        
        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime Birthday { get; set; }
    }
}
