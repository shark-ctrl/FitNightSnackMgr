using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.Models
{
    public class Result
    {
        /// <summary>
        /// 200为成功
        /// </summary>
        public int StatusCode { get; set; }


        public string Message { get; set; }
    }
}
