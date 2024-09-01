namespace DepiProject.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public int InsuranceID { get; set; }

        public InsuranceProvider InsuranceProvider { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<MedicalRecord> MedicalRecords { get; set; }
        public ICollection<Billing> Billings { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public ICollection<Medication> Medications { get; set; }
    }

}
