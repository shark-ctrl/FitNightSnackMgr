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
        [Required]
        [RegularExpression(@"\d{4,}")]
        public long CategoryNum { get; set; }

        [Required]
        [Display(Name ="分类名")]
        public string CategoryName { get; set; }
    }
}
