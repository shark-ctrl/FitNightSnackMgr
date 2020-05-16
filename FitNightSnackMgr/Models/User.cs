using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [Remote("CheckAccountUnique", "User", ErrorMessage = "该用户账号已存在")]
        [Display(Name ="账号")]
        public string UserAccount { get; set; }


        [Display(Name = "密码")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9~!@&%#_]{8,16}$")]
        [Required]
        public string Password { get; set; }


        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Money { get; set; }


        [Required]
        [RegularExpression(@"\d{10,}")]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }


    }
}
