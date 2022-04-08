using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models.Models
{
    public class OrderModel
    {
        public int? Id { get; set; }
        [DisplayName("Имя")]
        public string CustomerName { get; set; }
        [DisplayName("Фамилия")]
        public string CustomerSurName { get; set; }
        [DisplayName("Адрес")]
        public string Address { get; set; }
        public int WorkerId { get; set; }
        [DisplayName("Дата Заказа")] 
        public DateTime startTime { get; set; }
        [DisplayName("Дата Доставки")]
        public DateTime endTime { get; set; }
        [DisplayName("Статус")]
        public OrderEnum orderEnum { get; set; }
        public Dictionary<int?,(string,int?)> orderCargo { get; set; }
    }
}
