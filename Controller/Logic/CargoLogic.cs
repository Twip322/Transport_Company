using Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.Logic
{
    public class CargoLogic
    {
        public void CreateOrUpdate(Cargo model)
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
                element.order = model.order;
                element.OrderId = model.OrderId;
                context.SaveChanges();
            }
        }

        public void Delete(Cargo model)
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

        public List<Cargo> Read(Cargo model)
        {
            using (var context = new DataBase.DataBaseContext())
            {
                return context.Cargos
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new Cargo
                {
                    Id = rec.Id,
                    Name=rec.Name,
                    Weight=rec.Weight,
                    order=rec.order,
                    OrderId=rec.OrderId
                })
                .ToList();
            }
        }
    }
}
