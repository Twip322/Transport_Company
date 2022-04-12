using Controller.Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controller.Logic
{
    public class OrderCargoLogic
    {
        public void Create(Order orderModel,List<Cargo> cargoModel)
        {
            using (var context = new DataBase.DataBaseContext())
            {
                foreach(Cargo cargo in cargoModel)
                {
                    var element = new Cargo();
                    element.Name = cargo.Name;
                    element.Weight = cargo.Weight;
                    element.Order = cargo.Order;
                    context.Cargos.Add(cargo);
                }
                context.Orders.Add(orderModel);
                context.SaveChanges();
            }
        }
    }
}
