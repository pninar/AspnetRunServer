﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetRun.Web.ViewModels
{
    public class PatientViewModel : BaseViewModel
    {
        public string CityName { get; set; }
        public int? CityId { get; set; }
        public string KupahName { get; set; }
        public int? KupahId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Zehut { get; set; }
        //public CityViewModel City { get; set; }
        //public KupahViewModel Kupah { get; set; }
    }
}
