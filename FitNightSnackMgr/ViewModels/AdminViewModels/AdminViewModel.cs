using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FitNightSnackMgr.ViewModels
{
    public class AdminViewModel
    {
        public  Admin WorkMan { get; set; }

        public List<Admin> Admins { get; set; }
        public SelectList Permission { get; set; }

        public string AdminName { get; set; }
    }
}
