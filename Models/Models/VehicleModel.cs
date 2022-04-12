using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models.Models
{
    public class VehicleModel
    {
        public int? Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Скорость")]
        public int Speed { get; set; }
        [DisplayName("Грузоподъёмность")]
        public int Carrying { get; set; }
    }
}
