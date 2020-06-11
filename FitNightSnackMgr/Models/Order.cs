using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string OrderId { get; set; }

        public double Discount { get; set; }
       public string OrderDetail { get; set; }

        public int UserId { get; set; }

        public double TotalPrice { get; set; }

        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 0 未派送 1 完成
        /// </summary>
        public int Status { get; set; }
    }
}
