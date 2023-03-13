using AspnetRun.Application.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetRun.Application.Models
{
    public class PatientModel : BaseModel
    {
        public string CityName { get; set; }
        public string KupahName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Zehut { get; set; }
        public int AgeMonths { get; set; }
        public int AgeYears { get; set; }
    }
}
