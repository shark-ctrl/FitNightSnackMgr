using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FitNightSnackMgr.ViewModels.Categories
{
    public class CategoryViewModels
    {
        public List<SnackCategory> SnackCategories { get; set; }

        public string AdminName { get; set; }

        public SnackCategory SnackCategory { get; set; }

        public SelectList Status { get; set; }

        //create界面创建新分类需要的新分类号
        public long NewCategoryNum { get; set; }
    }
}
