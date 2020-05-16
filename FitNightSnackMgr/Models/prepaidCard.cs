using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitNightSnackMgr.Models
{
    public class prepaidCard
    {
        public int Id { get; set; }

        public string CardCode { get; set; }

        public string SecretKey { get; set; }

        public string UserAccount { get; set; }

        public int CardStatus { get; set; }


        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
