using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Controller.Models
{
    public class OrderCargo
    {
        public int? Id { get; set; }
        public int? CargoId { get; set; }
        public int? OrderId { get; set; }
        public int? Weight { get; set; }
        public virtual Cargo cargo { get; set; }
        public virtual Order order { get; set; }

    }
}
