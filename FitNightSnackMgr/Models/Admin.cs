using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FitNightSnackMgr.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "姓名不可为空")]
        [Display(Name ="姓名")]
        public string AdminName { get; set; }

        [Required(ErrorMessage ="账号不可为空")]
        [Display(Name = "账号")]  
        [RegularExpression(@"\d{6,}",ErrorMessage ="账号必须为数字,且大于6位")]
        public string LoginAccount { get; set; }

        [Required(ErrorMessage = "密码不可为空")]
        [Display(Name = "口令")]
        [RegularExpression(@"^(?![0-9]+$)(?![a-zA-Z]+$)[0-9A-Za-z]{6,16}$", ErrorMessage ="密码必须包含数字和字母，且必须大于6位")]
        public string PassWord { get; set; }
        [Display(Name = "权限")]
        public int Permissions { get; set; }

        [Display(Name ="创建时间")]
        public DateTime CreateTime { get; set; }
    }
}
