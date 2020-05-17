using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitNightSnackMgr.Tools
{
    public static class CongdingTools
    {
        public static bool CheckObj(object obj)
        {
            if (obj == null)
                return false;
            return true;
        
        }


       
    }
}
