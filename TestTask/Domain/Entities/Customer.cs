using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestTask.Domain.Entities
{
    // Create customer model
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        [Display(Name = "Name of сustomer")]
        public string CustomerName { get; set; }

        [Display(Name = "Order date")]
        public string OrderDate { get; set; }
    }
}
