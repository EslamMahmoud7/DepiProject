namespace DepiProject.Models
{
    public class Medication
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }

}
