using Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.Logic
{
    public class VehicleLogic
    {
        public void CreateOrUpdate(Vehicle model)
        {
            using (var context = new DataBase.DataBase())
            {
                Vehicle element = context.Vehicles.FirstOrDefault(rec =>
               rec.Name == model.Name && rec.Id != model.Id);
                if (element != null)
                {

                }
                else
                {
                    if (model.Id.HasValue)
                    {
                        element = context.Vehicles.FirstOrDefault(rec => rec.Id ==
                       model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                    }
                    else
                    {
                        element = new Vehicle();
                        context.Vehicles.Add(element);
                    }
                    element.Name = model.Name;
                    element.Speed = model.Speed;
                    element.Carrying = model.Carrying;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Vehicle model)
        {
            using (var context = new DataBase.DataBase())
            {
                Vehicle element = context.Vehicles.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Vehicles.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<Vehicle> Read(Vehicle model)
        {
            using (var context = new DataBase.DataBase())
            {
                return context.Vehicles
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new Vehicle
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Speed = rec.Speed,
                    Carrying=rec.Carrying
                })
                .ToList();
            }
        }
        public Vehicle ReadById(int? id)
        {
            using (var context = new DataBase.DataBase())
            {
                return context.Vehicles
                .Where(rec => rec.Id == id)
                .Select(rec => new Vehicle
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Speed = rec.Speed,
                    Carrying = rec.Carrying
                })
                .SingleOrDefault();
            }
        }
    }
}
