using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FitNightSnackMgr.Models
{
    public class Admin
    {
        public int Id { get; set; }


        [Display(Name ="姓名")]
        public string AdminName { get; set; }

        [Required]
        [Display(Name = "账号")]      
        public string LoginAccount { get; set; }

        [Required]
        [Display(Name = "口令")]
        public string PassWord { get; set; }
        [Display(Name = "权限")]
        public int Permissions { get; set; }

        [Display(Name ="创建时间")]
        public DateTime CreateTime { get; set; }
    }
}
