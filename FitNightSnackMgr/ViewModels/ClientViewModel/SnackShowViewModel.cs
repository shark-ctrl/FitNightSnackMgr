using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Models;

namespace FitNightSnackMgr.ViewModels.ClientViewModel
{
    public class SnackShowViewModel
    {
        public List<SnackInfo> SnackInfos { get; set; }

        public int PageTotal { get; set; }


        public int PageIndex { get; set; }
    }
}
