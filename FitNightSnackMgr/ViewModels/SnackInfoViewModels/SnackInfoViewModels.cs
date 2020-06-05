using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Models;
using FitNightSnackMgr.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FitNightSnackMgr.ViewModels.SnackInfoViewModels
{
    public class SnackInfoViewModels
    {
        public PaginatedList<SnackInfo> SnackInfos { get; set; }

        public SnackInfo SnackInfo { get; set; }



        public int SnackNum { get; set; }

       
        public string CategoryName { get; set; }

        public int? PageIndex { get; set; }

        public int? PageTotal { get; set; }

        public string SearchString { get; set; }

        [Required(ErrorMessage ="图片不可为空")]
        public IFormFile FormFile { get; set; }


        public SelectList CategoriesName { get; set; }

     





    }
}
