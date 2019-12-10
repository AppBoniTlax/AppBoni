using System.ComponentModel.DataAnnotations;

namespace AppBoni.Common.Models
{
    public class SurveyRequest  
    {

        public long Id { get; set; }

        [Required]
        public int Question1 { get; set; }

        [Required]
        public int Question2 { get; set; }

        [Required]
        public int Question3 { get; set; }

        [Required]
        public int Question4 { get; set; }

        [Required]
        public int Question5 { get; set; }

        [Required]
        public int Question6 { get; set; }

        [Required]
        public int Question7 { get; set; }

        [Required]
        public int Question8 { get; set; }

        [Required]
        public string Question9 { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}
