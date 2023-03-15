using AspnetRun.Core.Entities.Base;
using System;
using System.Collections.Generic;

namespace AspnetRun.Core.Entities
{
    public partial class Kupah : Entity
    {
        public Kupah()
        {
            Patient = new HashSet<Patient>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public bool RequiresHitchayvut { get; set; }
        public bool HasMonthlyReport { get; set; }
        public decimal ChildAge { get; set; }
        public bool ReportWithMaam { get; set; }
        public bool Chargeappointmentbytest { get; set; }
        public bool? Current { get; set; }
        public decimal AdultAbr { get; set; }
        public decimal AdultEquip { get; set; }
        public decimal AdultHearing { get; set; }
        public decimal AdultOther { get; set; }
        public decimal AdultSpeech { get; set; }
        public decimal AdultReturn { get; set; }
        public decimal AdultSpeecht { get; set; }
        public decimal AdultTymp { get; set; }
        public decimal ChildAbr { get; set; }
        public decimal ChildEquip { get; set; }
        public decimal ChildHearing { get; set; }
        public decimal ChildOther { get; set; }
        public decimal ChildReturn { get; set; }
        public decimal ChildSpeech { get; set; }
        public decimal ChildSpeecht { get; set; }
        public decimal ChildTymp { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierType { get; set; }
        public string SupplierSymb { get; set; }
        public string SupplierName { get; set; }
        public string MachozCode { get; set; }
        public decimal ClientCode { get; set; }
        public decimal PriceListId { get; set; }

        public virtual ICollection<Patient> Patient { get; set; }
    }
}
