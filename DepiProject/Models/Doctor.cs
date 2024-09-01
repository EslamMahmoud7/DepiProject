namespace DepiProject.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string Specialty { get; set; }
        public int DepartmentID { get; set; }

        public Department Department { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<MedicalRecord> MedicalRecords { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
    }

}
