using Controller.Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.Logic
{
    public class CargoLogic
    {
        public void CreateOrUpdate(CargoModel model)
        {
            using (var context = new DataBase.DataBaseContext())
            {
                Cargo element = context.Cargos.FirstOrDefault(rec =>
               rec.Id != model.Id);
                if (model.Id.HasValue)
                {
                    element = context.Cargos.FirstOrDefault(rec => rec.Id ==
                   model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Cargo();
                    context.Cargos.Add(element);
                }
                element.Name = model.Name;
                element.Weight = model.Weight;
                context.SaveChanges();
            }
        }

        public void Delete(CargoModel model)
        {
            using (var context = new DataBase.DataBaseContext())

            {
                Cargo element = context.Cargos.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Cargos.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<CargoModel> Read(Cargo model)
        {
            using (var context = new DataBase.DataBaseContext())
            {
                return context.Cargos
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new CargoModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Weight = rec.Weight,
                })
                .ToList();
            }
        }
        public CargoModel ReadById(int? id)
        {
            using (var context = new DataBase.DataBaseContext())
            {
                return context.Cargos
                .Where(rec => rec.Id == id)
                .Select(rec => new CargoModel
                {
                    Name = rec.Name,
                    Weight = rec.Weight,
                })
                .FirstOrDefault();
            }
        }
        public CargoModel ReadLast()
        {
            using (var context = new DataBase.DataBaseContext())
            {
                return context.Cargos
                .Select(rec => new CargoModel
                {
                    Id = rec.Id
                })
                .Last();
            }
        }
    }
}
