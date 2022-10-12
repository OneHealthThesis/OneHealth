using System.ComponentModel.DataAnnotations;
using System;

namespace dotnetapp.Models
{
    public class Person
    {
        [Key] public long IdUser { get; set; }

        [Required]public  bool IsAdmin { get; set; }

        [Required,
         StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters.")]
        public string Name { get; set; }

        [Required, StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters.")]
        public string LastName { get; set; }

        [Required] public Gender Gender { get; set; }

        [Required] public DateTime BirthDate { get; set; }

        public string Ethnicity { get; set; }

        public string Address { get; set; }
    }
}
