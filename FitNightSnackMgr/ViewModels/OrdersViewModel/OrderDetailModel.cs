using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Models;
using System.ComponentModel.DataAnnotations;
namespace FitNightSnackMgr.ViewModels.OrdersViewModel
{
    public class OrderDetailModel
    {

        [Display(Name ="订单编号")]
       public string OrderId { get; set; }
        [Display(Name = "折扣")]
        public double Discount { get; set; }
        [Display(Name = "订单详情")]
        public string OrderDetail { get; set; }
        [Display(Name = "总计")]
        public double TotalPrice { get; set; }
        [Display(Name = "订单状态")]
        public int Status { get; set; }
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Display(Name = "地址")]
        public string Address { get; set; }

    }
}
