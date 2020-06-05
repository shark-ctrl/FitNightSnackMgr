using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.Models
{
    public class SnackInfo
    {
        public int Id { get; set; }



        [Required(ErrorMessage ="小吃编号不可为空")]
        [Display(Name ="小吃编号")]
        [RegularExpression(@"\d{4,}", ErrorMessage ="小吃编号必须为数字 且大于4位")]
        public int SnackNum { get; set; }



        [Required(ErrorMessage = "分类编号不可为空")]
        [Display(Name ="所属分类")]
        public long CategoryId { get; set; }


        [Required(ErrorMessage = "商品名不可为空")]
        [Display(Name = "商品名")]
        public string Name { get; set; }


        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "价格不可为空")]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "单价")]
        public decimal Price { get; set; }

        [Display(Name = "图片")]
        public string ImgUrl { get; set; }

        [Required(ErrorMessage ="描述不可为空")]
        [Display(Name = "商品详细信息")]
        public string DetailInfo { get; set; }


        /// <summary>
        /// -1 为不可用 1为可用
        /// </summary>
        public int Status { get; set; }



    }
}
