using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.ViewModels.AdminViewModels
{
    public class AdminLoginViewModel
    {
        public int status { get; set; }
       
        public int UserId { get; set; }

        public string UserName { get; set; }


        public int Permission { get; set; }

        public string Account { get; set; }

        public string Token { get; set; }
    }
}
