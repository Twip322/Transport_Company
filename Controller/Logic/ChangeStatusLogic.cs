using Models.Enums;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controller.Logic
{
    public class ChangeStatusLogic
    {
        private readonly OrderLogic orderLogic = new OrderLogic();
        private readonly WorkerLogic workerLogic = new WorkerLogic();
        public void TakeOrderInWork(ChangeStatusBind changeStatusBind)
        {
            var order = orderLogic.Read(new OrderModel
            {
                Id = changeStatusBind.OrderId
            })?[0];
            if(order==null)
            {
                throw new Exception("Не найден Заказ");
            }
            orderLogic.CreateOrUpdate(new OrderModel
            {
                Id = order.Id,
                CustomerName = order.CustomerName,
                CustomerSurName = order.CustomerSurName,
                Address = order.Address,
                startTime = order.startTime,
                endTime = order.endTime,
                WorkerId = order.WorkerId,
                Cargos = order.Cargos,
                orderEnum = OrderEnum.Заказ_принят
            });
        }
        public void DeliveringStarted(ChangeStatusBind changeStatusBind)
        {
            var order = orderLogic.Read(new OrderModel
            {
                Id = changeStatusBind.OrderId
            })?[0];
            if (order == null)
            {
                throw new Exception("Не найден Заказ");
            }
            if(order.orderEnum!=OrderEnum.Заказ_принят)
            {
                throw new Exception("Заказ не принят");
            }    
            orderLogic.CreateOrUpdate(new OrderModel
            {
                Id = order.Id,
                CustomerName = order.CustomerName,
                CustomerSurName = order.CustomerSurName,
                Address = order.Address,
                startTime = order.startTime,
                endTime = order.endTime,
                WorkerId = order.WorkerId,
                Cargos = order.Cargos,
                orderEnum = OrderEnum.В_пути
            });
        }
        public void DeliveringEnded(ChangeStatusBind changeStatusBind)
        {
            var order = orderLogic.Read(new OrderModel
            {
                Id = changeStatusBind.OrderId
            })?[0];
            if (order == null)
            {
                throw new Exception("Не найден Заказ");
            }
            if (order.orderEnum != OrderEnum.В_пути)
            {
                throw new Exception("Заказ не в доставке");
            }
            orderLogic.CreateOrUpdate(new OrderModel
            {
                Id = order.Id,
                CustomerName = order.CustomerName,
                CustomerSurName = order.CustomerSurName,
                Address = order.Address,
                startTime = order.startTime,
                endTime = DateTime.Now,
                WorkerId = order.WorkerId,
                Cargos = order.Cargos,
                orderEnum = OrderEnum.Доставлен
            });
            var worker = workerLogic.ReadById(order.WorkerId);
            workerLogic.CreateOrUpdate(new WorkerModel
            {
                Id = worker.Id,
                Name = worker.Name,
                Surname = worker.Surname,
                IsFree = true,
                VehicleId = worker.VehicleId
            });
        }
        public void DeliveryPayed(ChangeStatusBind changeStatusBind)
        {
            var order = orderLogic.Read(new OrderModel
            {
                Id = changeStatusBind.OrderId
            })?[0];
            if (order == null)
            {
                throw new Exception("Не найден Заказ");
            }
            if (order.orderEnum != OrderEnum.Доставлен)
            {
                throw new Exception("Заказ не доставлен");
            }
            orderLogic.CreateOrUpdate(new OrderModel
            {
                Id = order.Id,
                CustomerName = order.CustomerName,
                CustomerSurName = order.CustomerSurName,
                Address = order.Address,
                startTime = order.startTime,
                endTime = order.endTime,
                WorkerId = order.WorkerId,
                Cargos = order.Cargos,
                orderEnum = OrderEnum.Оплачен
            });
        }

    }
}
