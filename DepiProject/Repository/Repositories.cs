using DepiProject.DbContextLayer;
using DepiProject.Interfaces;
using DepiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DepiProject.Repository
{
    public interface IPatientRepository : IGenericRepository<Patient> { }

    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(HospitalContext context) : base(context) { }
    }

    public interface IDoctorRepository : IGenericRepository<Doctor> { }

    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(HospitalContext context) : base(context) { }
    }

    public interface IAppointmentRepository : IGenericRepository<Appointment> { }

    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(HospitalContext context) : base(context) { }
    }
    public interface IMedicalRecordRepository : IGenericRepository<MedicalRecord> { }

    public class MedicalRecordRepository : GenericRepository<MedicalRecord>, IMedicalRecordRepository
    {
        public MedicalRecordRepository(HospitalContext context) : base(context) { }
    }
    public interface IBillingRepository : IGenericRepository<Billing> { }

    public class BillingRepository : GenericRepository<Billing>, IBillingRepository
    {
        public BillingRepository(HospitalContext context) : base(context) { }
    }
    public interface IDepartmentRepository : IGenericRepository<Department> { }

    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(HospitalContext context) : base(context) { }
    }
    public interface IMedicationRepository : IGenericRepository<Medication> { }

    public class MedicationRepository : GenericRepository<Medication>, IMedicationRepository
    {
        public MedicationRepository(HospitalContext context) : base(context) { }
    }

}
