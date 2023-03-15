using AspnetRun.Core.Entities.Base;
using System;
using System.Collections.Generic;

namespace AspnetRun.Core.Entities
{
    public partial class City : Entity
    {
        public City()
        {
            Patient = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Current { get; set; }
        public bool Default { get; set; }

        public virtual ICollection<Patient> Patient { get; set; }
    }
}
