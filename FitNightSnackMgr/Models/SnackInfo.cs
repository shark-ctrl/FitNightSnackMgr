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



        [Required]
        [Display(Name ="小吃编号")]
        public int SnackNum { get; set; }



        [Required]
        [Display(Name ="所属分类")]
        public int CategoryId { get; set; }





        [Required]
        [Display(Name = "商品名")]
        public string Name { get; set; }


        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "单价")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "图片")]
        public string ImgUrl { get; set; }

        [Required]
        [Display(Name = "商品详细信息")]
        public string DetailInfo { get; set; }



    }
}
