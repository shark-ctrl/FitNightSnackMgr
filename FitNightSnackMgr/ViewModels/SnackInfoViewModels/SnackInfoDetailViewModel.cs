using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Models;
using FitNightSnackMgr.ViewModels;

namespace FitNightSnackMgr.ViewModels.SnackInfoViewModels
{
    public class SnackInfoDetailViewModel
    {
        public SnackInfo SnackInfo { get; set; }

        [Display(Name = "所属类别")]
        public string CateGoryName { get; set; }
    }
}
