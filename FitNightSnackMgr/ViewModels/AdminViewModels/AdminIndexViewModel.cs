using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FitNightSnackMgr.ViewModels.AdminViewModels
{
    public class AdminIndexViewModel
    {


        public string AdminName { get; set; }

        public int Admin_permission { get; set; }

        public int AdminId { get; set; }

    }
}
