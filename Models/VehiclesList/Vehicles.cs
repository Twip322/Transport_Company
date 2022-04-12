using System;
using System.Collections.Generic;
using System.Text;
namespace Models.VehiclesList
{
    public class Vehicles
    {
        public Dictionary<int, (string, int, int)> Vehicle = new Dictionary<int, (string, int, int)>();
        public Dictionary<int, (string, int, int)> lists()
        {
            Vehicle.Add(0,("KAMAZ",45,600));
            Vehicle.Add(1, ("GAZelle", 90, 120));
            return Vehicle;
        }
        public Dictionary<int,(string,int,int)> getVehicle { get { return lists(); } }
    }
}
