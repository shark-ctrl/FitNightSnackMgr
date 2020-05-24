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

        [Required(ErrorMessage = "账号不可为空")]
        [Remote("CheckAccountUnique", "User", ErrorMessage = "该用户账号已存在")]
        [Display(Name ="账号")]
        public string UserAccount { get; set; }


        [Display(Name = "密码")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9~!@&%#_]{8,16}$")]
        [Required(ErrorMessage ="密码不可为空")]
        public string Password { get; set; }


        [Required(ErrorMessage = "用户名不可为空")]
        public string UserName { get; set; }


        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required(ErrorMessage = "金额不可为空")]
        [Display(Name = "钱包余额")]
        public decimal Money { get; set; }


        [RegularExpression(@"\d{10,}")]
        [Required(ErrorMessage = "电话号码不可为空")]
        [Display(Name = "电话号码")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "地址号码不可为空")]
        [Display(Name = "地址")]
        public string Address { get; set; }


        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }


        /// <summary>
        /// status 0为不可用 1为可用
        /// </summary>

        [Required(ErrorMessage = "账户使用状态不可为空")]
        public int Status { get; set; }


    }
}
