using System;
using Microsoft.EntityFrameworkCore;
using AspnetRun.Core.Entities;

namespace Kolgraph.Data
{
    public partial class KolgraphContext : DbContext
    {
        public KolgraphContext()
        {
        }

        public KolgraphContext(DbContextOptions<KolgraphContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<AppointmentTest> AppointmentTest { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Kupah> Kupah { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<TestGraphDef> TestGraphDef { get; set; }
        public virtual DbSet<TestResult> TestResult { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=MEROZ2012SERVER;Initial Catalog=Kolgraph;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("appointment");

                entity.HasIndex(e => e.AppointmentTypeId)
                    .HasName("apt_typ_id");

                entity.HasIndex(e => e.Bituachleumi)
                    .HasName("bituachl");

                entity.HasIndex(e => e.BranchId)
                    .HasName("idx_branch_id");

                entity.HasIndex(e => e.CameFlag)
                    .HasName("idx_came_flag");

                entity.HasIndex(e => e.ClinicianId)
                    .HasName("clncn_id");

                entity.HasIndex(e => e.Date)
                    .HasName("idx_date");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("emp_id");

                entity.HasIndex(e => e.HitchayvutNumber)
                    .HasName("hitchayvut");

                entity.HasIndex(e => e.Id)
                    .HasName("apptmnt_id")
                    .IsUnique();

                entity.HasIndex(e => e.KupahId)
                    .HasName("idx_kupah_id");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("language");

                entity.HasIndex(e => e.PatientId)
                    .HasName("idx_patient_id");

                entity.HasIndex(e => e.ReferreringDoctorId)
                    .HasName("rf_dct_id");

                entity.HasIndex(e => e.TestPlaceId)
                    .HasName("tst_plc_id");

                entity.HasIndex(e => e.YomanId)
                    .HasName("idx_yoman_id");

                entity.HasIndex(e => new { e.ClinicianId, e.Date })
                    .HasName("clin_date");

                entity.HasIndex(e => new { e.PatientId, e.Date })
                    .HasName("pat_date");

                entity.HasIndex(e => new { e.RoomId, e.Date })
                    .HasName("room_date");

                entity.HasIndex(e => new { e.YomanId, e.Date })
                    .HasName("yoman_date");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("TRIAL");

                entity.Property(e => e.AdultFlag)
                    .IsRequired()
                    .HasColumnName("adultFlag")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.AppointmentTypeId)
                    .HasColumnName("appointmentTypeId")
                    .HasComment("TRIAL");

                entity.Property(e => e.Bituachleumi)
                    .HasColumnName("bituachleumi")
                    .HasComment("TRIAL");

                entity.Property(e => e.BranchId)
                    .HasColumnName("branchId")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.CameFlag)
                    .HasColumnName("cameFlag")
                    .HasComment("TRIAL");

                entity.Property(e => e.CameNotes)
                    .HasColumnName("cameNotes")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.CauseOreferral)
                    .HasColumnName("causeOReferral")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.ClinicianId)
                    .HasColumnName("clinicianId")
                    .HasComment("TRIAL");

                entity.Property(e => e.ClinicianId2)
                    .HasColumnName("clinicianId2")
                    .HasComment("TRIAL");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasComment("TRIAL");

                entity.Property(e => e.DiagnosisIdL)
                    .HasColumnName("diagnosisIdL")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.DiagnosisIdR)
                    .HasColumnName("diagnosisIdR")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.DiagnosisL)
                    .HasColumnName("diagnosisL")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.DiagnosisR)
                    .HasColumnName("diagnosisR")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employeeId")
                    .HasComment("TRIAL");

                entity.Property(e => e.HitchayvutAmount)
                    .HasColumnName("hitchayvutAmount")
                    .HasComment("TRIAL");

                entity.Property(e => e.HitchayvutDate)
                    .HasColumnName("hitchayvutDate")
                    .HasColumnType("date")
                    .HasComment("TRIAL");

                entity.Property(e => e.HitchayvutNumber)
                    .HasColumnName("hitchayvutNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.KupahId)
                    .HasColumnName("kupahId")
                    .HasComment("TRIAL");

                entity.Property(e => e.Kupahnotes)
                    .HasColumnName("kupahnotes")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("languageId")
                    .HasComment("TRIAL");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.OtherDoctor)
                    .HasColumnName("otherDoctor")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.PatientId)
                    .HasColumnName("patientId")
                    .HasComment("TRIAL");

                entity.Property(e => e.Private)
                    .HasColumnName("private")
                    .HasComment("TRIAL");

                entity.Property(e => e.ReasonForReferral)
                    .HasColumnName("reasonForReferral")
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Referral)
                    .HasColumnName("referral")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.Referralreason)
                    .HasColumnName("referralreason")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.ReferreringDoctorId)
                    .HasColumnName("referreringDoctorId")
                    .HasComment("TRIAL");

                entity.Property(e => e.RemHitchayvut)
                    .HasColumnName("remHitchayvut")
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.RoomId)
                    .HasColumnName("roomId")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpeechDiagnosis)
                    .HasColumnName("speechDiagnosis")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.SpeechDiagnosisId)
                    .HasColumnName("speechDiagnosisId")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.TestPlaceId)
                    .HasColumnName("testPlaceId")
                    .HasComment("TRIAL");

                entity.Property(e => e.YomanId)
                    .HasColumnName("yomanId")
                    .HasComment("TRIAL");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_appointment_branches");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_appointment_patient");
            });

            modelBuilder.Entity<AppointmentTest>(entity =>
            {
                entity.ToTable("appointmentTest");

                entity.HasIndex(e => e.AppointmentId)
                    .HasName("apptmnt_id");

                entity.HasIndex(e => e.Id)
                    .HasName("apt_tst_id");

                entity.HasIndex(e => e.MachineId)
                    .HasName("idx_machine_id");

                entity.HasIndex(e => e.TestId)
                    .HasName("idx_test_id");

                entity.HasIndex(e => new { e.AppointmentId, e.TestId })
                    .HasName("appt_test");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("TRIAL");

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("appointmentId")
                    .HasComment("TRIAL");

                entity.Property(e => e.ClinicianId)
                    .HasColumnName("clinicianId")
                    .HasComment("TRIAL");

                entity.Property(e => e.ClinicianId2)
                    .HasColumnName("clinicianId2")
                    .HasComment("TRIAL");

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnName("file")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.HitchayvutDate)
                    .HasColumnName("hitchayvutDate")
                    .HasColumnType("date")
                    .HasComment("TRIAL");

                entity.Property(e => e.HitchayvutNumber)
                    .IsRequired()
                    .HasColumnName("hitchayvutNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasComment("TRIAL");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.Referral)
                    .IsRequired()
                    .HasColumnName("referral")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasColumnName("summary")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.TestId)
                    .HasColumnName("testId")
                    .HasComment("TRIAL");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentTest)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_appointmentTest_appointment");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("bank");

                entity.HasIndex(e => e.Current)
                    .HasName("idx_current");

                entity.HasIndex(e => e.Id)
                    .HasName("idx_id")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("idx_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("TRIAL");

                entity.Property(e => e.Bankcode)
                    .IsRequired()
                    .HasColumnName("bankcode")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Current)
                    .IsRequired()
                    .HasColumnName("current")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("branch");

                entity.HasIndex(e => e.Current)
                    .HasName("idx_current");

                entity.HasIndex(e => e.Id)
                    .HasName("idx_branch_id")
                    .IsUnique();

                entity.HasIndex(e => e.Namee)
                    .HasName("idx_namee");

                entity.HasIndex(e => e.Nameh)
                    .HasName("idx_nameh");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("TRIAL");

                entity.Property(e => e.Addresse)
                    .HasColumnName("addresse")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Addressh)
                    .IsRequired()
                    .HasColumnName("addressh")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasComment("TRIAL");

                entity.Property(e => e.Desce)
                    .HasColumnName("desce")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Desch)
                    .IsRequired()
                    .HasColumnName("desch")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.LogoFileName)
                    .IsRequired()
                    .HasColumnName("logoFileName")
                    .HasComment("TRIAL");

                entity.Property(e => e.Namee)
                    .HasColumnName("namee")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Nameh)
                    .IsRequired()
                    .HasColumnName("nameh")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasColumnName("telephone")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.TestPlaceId)
                    .HasColumnName("testPlaceId")
                    .HasComment("TRIAL");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.HasIndex(e => e.Current)
                    .HasName("idx_current");

                entity.HasIndex(e => e.Default)
                    .HasName("idx_default");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("TRIAL");

                entity.Property(e => e.Current)
                    .IsRequired()
                    .HasColumnName("current")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Default)
                    .HasColumnName("default")
                    .HasComment("TRIAL");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");
            });

            modelBuilder.Entity<Kupah>(entity =>
            {
                entity.ToTable("kupah");

                entity.HasIndex(e => e.Current)
                    .HasName("idx_current");

                entity.HasIndex(e => e.Name)
                    .HasName("idx_name");

                entity.HasIndex(e => e.PriceListId)
                    .HasName("price_list");

                entity.HasIndex(e => e.RequiresHitchayvut)
                    .HasName("hitchayvut");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(5, 0)")
                    .HasComment("TRIAL")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdultAbr)
                    .HasColumnName("adult_abr")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.AdultEquip)
                    .HasColumnName("adult_equip")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.AdultHearing)
                    .HasColumnName("adult_hearing")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.AdultOther)
                    .HasColumnName("adult_other")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.AdultReturn)
                    .HasColumnName("adult_return")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.AdultSpeech)
                    .HasColumnName("adult_speech")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.AdultSpeecht)
                    .HasColumnName("adult_speecht")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.AdultTymp)
                    .HasColumnName("adult_tymp")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.Chargeappointmentbytest)
                    .HasColumnName("chargeappointmentbytest")
                    .HasComment("TRIAL");

                entity.Property(e => e.ChildAbr)
                    .HasColumnName("child_abr")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.ChildAge)
                    .HasColumnName("child_age")
                    .HasColumnType("numeric(3, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.ChildEquip)
                    .HasColumnName("child_equip")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.ChildHearing)
                    .HasColumnName("child_hearing")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.ChildOther)
                    .HasColumnName("child_other")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.ChildReturn)
                    .HasColumnName("child_return")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.ChildSpeech)
                    .HasColumnName("child_speech")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.ChildSpeecht)
                    .HasColumnName("child_speecht")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.ChildTymp)
                    .HasColumnName("child_tymp")
                    .HasColumnType("numeric(9, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.ClientCode)
                    .HasColumnName("client_code")
                    .HasColumnType("numeric(11, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.Current)
                    .IsRequired()
                    .HasColumnName("current")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.HasMonthlyReport)
                    .HasColumnName("has_monthly_report")
                    .HasComment("TRIAL");

                entity.Property(e => e.MachozCode)
                    .IsRequired()
                    .HasColumnName("machoz_code")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.PriceListId)
                    .HasColumnName("price_list_id")
                    .HasColumnType("numeric(11, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.ReportWithMaam)
                    .HasColumnName("report_with_maam")
                    .HasComment("TRIAL");

                entity.Property(e => e.RequiresHitchayvut)
                    .HasColumnName("requires_hitchayvut")
                    .HasComment("TRIAL");

                entity.Property(e => e.SupplierCode)
                    .IsRequired()
                    .HasColumnName("supplier_code")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasColumnName("supplier_name")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.SupplierSymb)
                    .IsRequired()
                    .HasColumnName("supplier_symb")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.SupplierType)
                    .IsRequired()
                    .HasColumnName("supplier_type")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("patient");

                entity.HasIndex(e => e.BranchId)
                    .HasName("idx_branch_id");

                entity.HasIndex(e => e.CityId)
                    .HasName("idx_city");

                entity.HasIndex(e => e.Current)
                    .HasName("idx_current");

                entity.HasIndex(e => e.Dob)
                    .HasName("idx_dob");

                entity.HasIndex(e => e.KupahId)
                    .HasName("idx_kupah_id");

                entity.HasIndex(e => e.LastName)
                    .HasName("idx_last_name");

                entity.HasIndex(e => e.OpenDate)
                    .HasName("idx_open_date");

                entity.HasIndex(e => e.Phone)
                    .HasName("idx_phone");

                entity.HasIndex(e => e.Zehut)
                    .HasName("trimzehut");

                entity.HasIndex(e => new { e.Areacode1, e.Phone })
                    .HasName("area1_phon");

                entity.HasIndex(e => new { e.FirstName, e.LastName })
                    .HasName("idx_first_name");

                entity.HasIndex(e => new { e.LastName, e.FirstName })
                    .HasName("whole_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.AddressPlace)
                    .IsRequired()
                    .HasColumnName("addressPlace")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Areacode1)
                    .IsRequired()
                    .HasColumnName("areacode1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Areacode2)
                    .IsRequired()
                    .HasColumnName("areacode2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Areacode3)
                    .IsRequired()
                    .HasColumnName("areacode3")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.BranchId)
                    .HasColumnName("branchId")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.Current)
                    .IsRequired()
                    .HasColumnName("current")
                    .HasDefaultValueSql("((1))")
                    .HasComment("TRIAL");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date")
                    .HasComment("TRIAL");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employeeId")
                    .HasComment("TRIAL");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.KupahId)
                    .HasColumnName("kupahId")
                    .HasColumnType("numeric(5, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.OpenDate)
                    .HasColumnName("openDate")
                    .HasColumnType("date")
                    .HasComment("TRIAL");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasColumnName("phone2")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Phone2Place)
                    .IsRequired()
                    .HasColumnName("phone2Place")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Phone3)
                    .IsRequired()
                    .HasColumnName("phone3")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Phone3Place)
                    .IsRequired()
                    .HasColumnName("phone3Place")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.PhonePlace)
                    .IsRequired()
                    .HasColumnName("phonePlace")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Sugzehut)
                    .IsRequired()
                    .HasColumnName("sugzehut")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Z')")
                    .HasComment("TRIAL");

                entity.Property(e => e.Yob)
                    .HasColumnName("yob")
                    .HasColumnType("numeric(5, 0)")
                    .HasComment("TRIAL");

                entity.Property(e => e.Zehut)
                    .IsRequired()
                    .HasColumnName("zehut")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("zip")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_patient_branch");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_patient_city");

                entity.HasOne(d => d.Kupah)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.KupahId)
                    .HasConstraintName("FK_patient_kupah");
            });

            modelBuilder.Entity<TestGraphDef>(entity =>
            {
                entity.ToTable("testGraphDef");

                entity.HasIndex(e => e.TestId)
                    .HasName("idx_test_id");

                entity.HasIndex(e => new { e.TestId, e.Row })
                    .HasName("test_row");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Heading)
                    .IsRequired()
                    .HasColumnName("heading")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.ImageL)
                    .IsRequired()
                    .HasColumnName("imageL")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.ImageR)
                    .IsRequired()
                    .HasColumnName("imageR")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.LabelColorL)
                    .IsRequired()
                    .HasColumnName("labelColorL")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.LabelColorR)
                    .IsRequired()
                    .HasColumnName("labelColorR")
                    .HasColumnType("text")
                    .HasComment("TRIAL");

                entity.Property(e => e.LabelL)
                    .HasColumnName("labelL")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LabelR)
                    .HasColumnName("labelR")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Row)
                    .HasColumnName("row")
                    .HasComment("TRIAL");

                entity.Property(e => e.TestId)
                    .HasColumnName("testId")
                    .HasComment("TRIAL");
            });

            modelBuilder.Entity<TestResult>(entity =>
            {
                entity.ToTable("testResult");

                entity.HasIndex(e => e.AppointmentId)
                    .HasName("appointmen");

                entity.HasIndex(e => e.AppointmentTestId)
                    .HasName("apt_tst_id");

                entity.HasIndex(e => e.TestId)
                    .HasName("idx_test_id");

                entity.HasIndex(e => new { e.AppointmentTestId, e.TestId, e.RowNumber })
                    .HasName("apt_tst_rw");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("appointmentId")
                    .HasComment("TRIAL");

                entity.Property(e => e.AppointmentTestId)
                    .HasColumnName("appointmentTestId")
                    .HasComment("TRIAL");

                entity.Property(e => e.Resultsl)
                    .IsRequired()
                    .HasColumnName("resultsl")
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Resultsnoear)
                    .IsRequired()
                    .HasColumnName("resultsnoear")
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.Resultsr)
                    .IsRequired()
                    .HasColumnName("resultsr")
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TRIAL");

                entity.Property(e => e.RowNumber)
                    .HasColumnName("rowNumber")
                    .HasComment("TRIAL");

                entity.Property(e => e.TestId)
                    .HasColumnName("testId")
                    .HasComment("TRIAL");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.TestResult)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_testResult_appointment");

                entity.HasOne(d => d.AppointmentTest)
                    .WithMany(p => p.TestResult)
                    .HasForeignKey(d => d.AppointmentTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_testResult_appointmentTest");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
