using System;
using System.Collections.Generic;

namespace AspnetRun.Core.Entities
{
    public partial class Branch
    {
        public Branch()
        {
            Appointment = new HashSet<Appointment>();
            Patient = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Namee { get; set; }
        public string Nameh { get; set; }
        public string Addresse { get; set; }
        public string Addressh { get; set; }
        public string Desce { get; set; }
        public string Desch { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public bool Current { get; set; }
        public string LogoFileName { get; set; }
        public int TestPlaceId { get; set; }

        public virtual ICollection<Appointment> Appointment { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
