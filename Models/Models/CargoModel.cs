using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class CargoModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        [Required]
        public OrderModel OrderModel { get; set; }
    }
}
