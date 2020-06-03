using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.ViewModels.AdminViewModels
{
    public class ResetPwdModel
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public string NewPwd { get; set; }
    }
}
