using Controller.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Controller.Models
{
    public class Worker
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsFree { get; set; }
        public int? VehicleId { get; set; }

    }
}
