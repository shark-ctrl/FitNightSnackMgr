using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace FitNightSnackMgr.ViewModels.CardViewModel
{
    public class CardCreateViewModel
    {

        public prepaidCard Card { get; set; }


        public string CardCode{get;set;}

        public string CarsSecret { get; set; }
    }
}
