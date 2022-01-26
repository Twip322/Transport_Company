using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Controller.Models
{
    public class Order
    {
        public int? Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurName { get; set; }
        public string Address { get; set; }
        public string Cargo { get; set; }
        public Worker Worker { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}
