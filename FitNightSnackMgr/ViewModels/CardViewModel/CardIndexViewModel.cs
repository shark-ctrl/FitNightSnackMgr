using FitNightSnackMgr.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.ViewModels.CardViewModel
{
    public class CardIndexViewModel
    {
          
        public List<prepaidCard> Cards { get; set; }
        



        public string SearchString { get; set; }



        public int PageIndex { get; set; }
        



        public int PageTotal { get; set; }

    }
}
