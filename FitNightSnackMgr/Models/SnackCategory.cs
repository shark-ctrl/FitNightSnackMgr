using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.Models
{
    public class SnackCategory
    {
        public int Id { get; set; }

        [Display(Name ="分类编号")]
        [Required(ErrorMessage = "分类号不可为空")]
        [RegularExpression(@"\d{4,}",ErrorMessage ="分类号必须大于四位，如1001")]
        public long CategoryNum { get; set; }

        [Required(ErrorMessage ="分类名不可为空")]
        [Display(Name ="分类名")]
        public string CategoryName { get; set; }

        
        [Display(Name = "描述")]
        [Required(ErrorMessage = "描述不可为空")]
        public string Description { get; set; }

        [Display(Name = "分类使用状态")]
        public int Status { get; set; }
    }
}
