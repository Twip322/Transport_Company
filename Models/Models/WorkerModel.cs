using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models.Models
{
    public class WorkerModel
    {
        public int? Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        public bool IsFree { get; set; }
        public int? VehicleId { get; set; }
    }
}
