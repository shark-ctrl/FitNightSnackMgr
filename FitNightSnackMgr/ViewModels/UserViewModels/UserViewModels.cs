using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FitNightSnackMgr.ViewModels.UserViewModels
{
    public class UserViewModels
    {
        public List<User> Users { get; set; }

        public string AdminName { get; set; }

        public User User { get; set; }


        public string SearchString { get; set; }



        public int PageIndex { get; set; }



        public int PageTotal { get; set; }




    }
}
