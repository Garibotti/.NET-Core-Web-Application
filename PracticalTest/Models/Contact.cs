using System;
using System.ComponentModel.DataAnnotations;

namespace PracticalTest.Models
{
    public class Contact
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}
