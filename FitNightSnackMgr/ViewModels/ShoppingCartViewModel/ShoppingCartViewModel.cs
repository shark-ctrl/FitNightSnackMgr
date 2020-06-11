using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.ViewModels.ShoppingCartViewModel
{
    public class ShoppingCartViewModel
    {
        public int SnackId { get; set; }
        public string SnackName { get; set; }

        public decimal UnitPrice { get; set; }

        public int SnackCount { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
