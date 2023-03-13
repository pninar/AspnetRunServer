using System;
using System.Collections.Generic;

namespace AspnetRun.Core.Entities
{
    public partial class AppointmentTest
    {
        public AppointmentTest()
        {
            TestResult = new HashSet<TestResult>();
        }

        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public int TestId { get; set; }
        public string Notes { get; set; }
        public string HitchayvutNumber { get; set; }
        public DateTime HitchayvutDate { get; set; }
        public int MachineId { get; set; }
        public string File { get; set; }
        public int ClinicianId { get; set; }
        public int ClinicianId2 { get; set; }
        public string Summary { get; set; }
        public string Referral { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual ICollection<TestResult> TestResult { get; set; }
    }
}
