using System;
using System.ComponentModel.DataAnnotations;

namespace asp.net_core_mvc_webapp_sample.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Age { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Designation { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]
        public string Detail { get; set; }
    }
    
    public enum Gender
    {
        Male,
        Female
    }
}