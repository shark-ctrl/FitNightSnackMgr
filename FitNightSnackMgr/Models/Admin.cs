using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FitNightSnackMgr.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "账号")]      
        public string LoginAccount { get; set; }

        [Required]
        [Display(Name = "口令")]
        public string PassWord { get; set; }

       
        public DateTime CreateTime { get; set; }
    }
}
