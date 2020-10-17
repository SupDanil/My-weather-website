using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Domain.Entities
{
    // Create manager model
    public class Manager
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        [Display(Name = "Name of manager")]
        public string Name { get; set; }

        [Display(Name = "Surname of manager")]
        public string SurName { get; set; }
    }
}
