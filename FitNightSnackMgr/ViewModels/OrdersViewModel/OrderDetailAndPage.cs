using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.ViewModels;

namespace FitNightSnackMgr.ViewModels.OrdersViewModel
{
    public class OrderDetailAndPage
    {
        public List<OrderDetailModel> OrderDetailModels { get; set; }

        public int PageIndex { get; set; }

        public int PageTotal { get; set; }

        public string SearchString { get; set; }
    }
}
