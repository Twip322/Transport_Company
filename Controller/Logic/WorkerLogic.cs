using Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.Logic
{
    public class WorkerLogic
    {
        public void CreateOrUpdate(Worker model)
        {
            using (var context = new DataBase.DataBase())
            {
                Worker element = context.Workers.FirstOrDefault(rec =>
               rec.Name == model.Name && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть компонент с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.Workers.FirstOrDefault(rec => rec.Id ==
                   model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Worker();
                    context.Workers.Add(element);
                }
                element.Name = model.Name;
                element.Surname = model.Surname;
                element.Vehicle = model.Vehicle;
                context.SaveChanges();
            }
        }

        public void Delete(Worker model)
        {
            using (var context = new DataBase.DataBase())
            {
                Worker element = context.Workers.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Workers.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<Worker> Read(Worker model)
        {
            using (var context = new DataBase.DataBase())
            {
                return context.Workers
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new Worker
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Surname = rec.Surname,
                    Vehicle=rec.Vehicle
                })
                .ToList();
            }
        }
    }
}
