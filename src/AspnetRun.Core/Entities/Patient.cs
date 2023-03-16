using AspnetRun.Core.Entities.Base;
using System;
using System.Collections.Generic;

namespace AspnetRun.Core.Entities
{
    public partial class Patient : Entity
    {
        public Patient()
        {
            Appointment = new HashSet<Appointment>();
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Sugzehut { get; set; }
        public string Zehut { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string PhonePlace { get; set; }
        public string Phone2Place { get; set; }
        public string Address { get; set; }
        public string Phone3Place { get; set; }
        public int? CityId { get; set; }
        public string Zip { get; set; }
        public int? KupahId { get; set; }
        public string Notes { get; set; }
        public DateTime Dob { get; set; }
        public decimal Yob { get; set; }
        public bool? Current { get; set; }
        public string AddressPlace { get; set; }
        public string Areacode1 { get; set; }
        public string Areacode2 { get; set; }
        public string Areacode3 { get; set; }
        public DateTime OpenDate { get; set; }
        public string Email { get; set; }
        public int BranchId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual City City { get; set; }
        public virtual Kupah Kupah { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }
    }
}
