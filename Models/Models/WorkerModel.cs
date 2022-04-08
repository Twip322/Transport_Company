using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class WorkerModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsFree { get; set; }
        public int? VehicleId { get; set; }
    }
}
