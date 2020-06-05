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
    public class SnackEditViewModel
    {
        public SnackInfo SnackInfo { get; set; }




        public IFormFile PushFile { get; set; }

        [Required(ErrorMessage = "图片不可为空")]
        public IFormFile FormFile { get; set; }




        public string CategoryName { get; set; }


        public SelectList CateGorieNameList { get; set; }
    }
}
