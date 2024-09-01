namespace DepiProject.Models
{
    public class MedicalRecord
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
    }

}
