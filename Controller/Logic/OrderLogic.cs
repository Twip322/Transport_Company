using Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller.Logic
{
    public class OrderLogic
    {
        public void CreateOrUpdate(Order model)
        {
            using (var context = new DataBase.DataBase())
            {
                Order element = context.Orders.FirstOrDefault(rec =>
               rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть компонент с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.Orders.FirstOrDefault(rec => rec.Id ==
                   model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Order();
                    context.Orders.Add(element);
                }
                element.CustomerName = model.CustomerName;
                element.CustomerSurName = model.CustomerSurName;
                element.Address = model.Address;
                element.Cargo = model.Cargo;
                element.Worker = model.Worker;
                element.startTime = model.startTime;
                element.endTime = model.endTime;
                context.SaveChanges();
            }
        }

        public void Delete(Order model)
        {
            using (var context = new DataBase.DataBase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<Order> Read(Order model)
        {
            using (var context = new DataBase.DataBase())
            {
                return context.Orders
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new Order
                {
                    Id = rec.Id,
                    CustomerName = rec.CustomerName,
                    CustomerSurName=rec.CustomerSurName,
                    Cargo=rec.Cargo,
                    Address=rec.Address,
                    Worker=rec.Worker,
                    startTime=rec.startTime,
                    endTime=rec.endTime
                })
                .ToList();
            }
        }
    }
}
