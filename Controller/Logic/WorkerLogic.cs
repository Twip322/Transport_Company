using Controller.Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.Logic
{
    public class WorkerLogic
    {
        public void CreateOrUpdate(WorkerModel model)
        {
            using (var context = new DataBase.DataBaseContext())
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
                element.IsFree = model.IsFree;
                element.VehicleId = model.VehicleId;
                context.SaveChanges();
            }
        }

        public void Delete(WorkerModel model)
        {
            using (var context = new DataBase.DataBaseContext())
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

        public List<WorkerModel> Read(WorkerModel model)
        {
            using (var context = new DataBase.DataBaseContext())
            {
                return context.Workers
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new WorkerModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Surname = rec.Surname,
                    VehicleId=rec.VehicleId,
                    IsFree=rec.IsFree
                })
                .ToList();
            }
        }
        public WorkerModel ReadById(int id)
        {
            using (var context = new DataBase.DataBaseContext())
            {
                return context.Workers
                .Where(rec => rec.Id == id)
                .Select(rec => new WorkerModel
                {
                    Id=rec.Id,
                    VehicleId = rec.VehicleId,
                    Name=rec.Name,
                    IsFree=rec.IsFree,
                    Surname=rec.Surname
                })
                .SingleOrDefault();
            }
        }
        public List<WorkerModel> ReadByIsFree()
        {
            using (var context = new DataBase.DataBaseContext())
            {
                return context.Workers
                .Where(rec => rec.IsFree == true)
                .Select(rec => new WorkerModel
                {
                    VehicleId = rec.VehicleId,
                    Id=rec.Id,
                    IsFree=rec.IsFree,
                    Name=rec.Name
                })
                .ToList();
            }
        }
    }
}
