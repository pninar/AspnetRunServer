using System;
using System.Collections.Generic;

namespace AspnetRun.Core.Entities
{
    public partial class TestResult
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public int AppointmentTestId { get; set; }
        public int TestId { get; set; }
        public int RowNumber { get; set; }
        public string Resultsr { get; set; }
        public string Resultsl { get; set; }
        public string Resultsnoear { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual AppointmentTest AppointmentTest { get; set; }
    }
}
