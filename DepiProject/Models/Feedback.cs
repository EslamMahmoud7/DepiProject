namespace DepiProject.Models
{
    public class Feedback
    {
        public int ID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
    }

}
