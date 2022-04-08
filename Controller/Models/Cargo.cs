using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Controller.Models
{
    public class Cargo
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        [Required]
        public virtual Order Order { get; set; }
    }
}
