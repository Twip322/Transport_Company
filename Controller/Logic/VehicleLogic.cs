using Controller.Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.Logic
{
    public class VehicleLogic
    {
        public void CreateOrUpdate(VehicleModel model)
        {
            using (var context = new DataBase.DataBaseContext())
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

        public void Delete(VehicleModel model)
        {
            using (var context = new DataBase.DataBaseContext())
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

        public List<VehicleModel> Read(VehicleModel model)
        {
            using (var context = new DataBase.DataBaseContext())
            {
                return context.Vehicles
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new VehicleModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Speed = rec.Speed,
                    Carrying=rec.Carrying
                })
                .ToList();
            }
        }
        public VehicleModel ReadById(int? id)
        {
            using (var context = new DataBase.DataBaseContext())
            {
                return context.Vehicles
                .Where(rec => rec.Id == id)
                .Select(rec => new VehicleModel
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
