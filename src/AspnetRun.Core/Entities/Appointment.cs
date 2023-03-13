using System;
using System.Collections.Generic;

namespace AspnetRun.Core.Entities
{
    public partial class Appointment
    {
        public Appointment()
        {
            AppointmentTest = new HashSet<AppointmentTest>();
            TestResult = new HashSet<TestResult>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public int AppointmentTypeId { get; set; }
        public DateTime Date { get; set; }
        public int PatientId { get; set; }
        public int ClinicianId { get; set; }
        public int YomanId { get; set; }
        public int RoomId { get; set; }
        public bool Private { get; set; }
        public string HitchayvutNumber { get; set; }
        public decimal? RemHitchayvut { get; set; }
        public int? HitchayvutAmount { get; set; }
        public DateTime? HitchayvutDate { get; set; }
        public bool CameFlag { get; set; }
        public string CameNotes { get; set; }
        public string DiagnosisIdR { get; set; }
        public string DiagnosisIdL { get; set; }
        public string DiagnosisR { get; set; }
        public string DiagnosisL { get; set; }
        public string Referral { get; set; }
        public string Kupahnotes { get; set; }
        public string Notes { get; set; }
        public string SpeechDiagnosis { get; set; }
        public string SpeechDiagnosisId { get; set; }
        public bool? AdultFlag { get; set; }
        public int? ReferreringDoctorId { get; set; }
        public string ReasonForReferral { get; set; }
        public string CauseOreferral { get; set; }
        public int TestPlaceId { get; set; }
        public int? KupahId { get; set; }
        public bool? Bituachleumi { get; set; }
        public string OtherDoctor { get; set; }
        public string Referralreason { get; set; }
        public int? ClinicianId2 { get; set; }
        public int LanguageId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<AppointmentTest> AppointmentTest { get; set; }
        public virtual ICollection<TestResult> TestResult { get; set; }
    }
}
