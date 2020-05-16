using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.Models
{
    public class ShoppingCart
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        public int SnackNum { get; set; }

        public int UnitNum { get; set; }

        public int Num { get; set; }


        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "小计")]
        public decimal TotalMoney { get; set; }
    }
}
