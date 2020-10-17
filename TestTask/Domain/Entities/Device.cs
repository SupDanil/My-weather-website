using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Domain.Entities
{
    // Create device model
    public class Device
    {
        [Required]
        public virtual int Id { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        [Display(Name = "Manufacturer of device")]
        public string ManufacturerOfDevice { get; set; }

        [Display(Name = "Type of device")]
        public string TypeOfDevice { get; set; }

        [Display(Name = "Model of device")]
        public string ModelOfDevice { get; set; }

        [Display(Name = "Сondition of device")]
        public string ConditionOfDevice { get; set; }
    }
}
