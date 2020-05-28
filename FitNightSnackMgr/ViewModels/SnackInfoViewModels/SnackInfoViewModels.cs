using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Models;
using FitNightSnackMgr.Tools;

namespace FitNightSnackMgr.ViewModels.SnackInfoViewModels
{
    public class SnackInfoViewModels
    {
        public PaginatedList<SnackInfo> SnackInfos { get; set; }


        public string AdminName { get; set; }


        public string CategoryName { get; set; }

        public int? PageIndex { get; set; }

        public int? PageTotal { get; set; }

        public string SearchString { get; set; }

    }
}
