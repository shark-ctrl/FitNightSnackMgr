using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.Models
{
    public class prepaidCard
    {
        
        public int Id { get; set; }
        [Display(Name ="卡号")]
        public string CardCode { get; set; }
        [Display(Name = "密钥")]

        public string SecretKey { get; set; }
       

        public string UserAccount { get; set; }

        /// <summary>
        /// -1废弃 1可用
        /// </summary>
        public int CardStatus { get; set; }

        [Display(Name = "金额")]

        public double Price { get; set; }

    }
}
