using Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace Controller.Logic
{
    public class OrderLogic
    {
        public void CreateOrUpdate(OrderModel model)
        {
            using (var context = new DataBase.DataBaseContext())
            {
                Order element = context.Orders.FirstOrDefault(rec =>
               rec.Id != model.Id);
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
                element.WorkerId = model.WorkerId;
                element.startTime = model.startTime;
                element.endTime = model.endTime;
                element.orderEnum = model.orderEnum;
                context.SaveChanges();
            }
        }

        public void Delete(OrderModel model)
        {
            using (var context = new DataBase.DataBaseContext())
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

        public List<OrderModel> Read(OrderModel model)
        {
            using (var context = new DataBase.DataBaseContext())
            {
                return context.Orders
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
                .Select(rec => new OrderModel
                {
                    Id = rec.Id,
                    CustomerName = rec.CustomerName,
                    CustomerSurName = rec.CustomerSurName,
                    Address = rec.Address,
                    WorkerId = rec.WorkerId,
                    startTime = rec.startTime,
                    endTime = rec.endTime,
                    orderEnum=rec.orderEnum,
                })
                .ToList();
            }
        }
    }
}
