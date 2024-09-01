namespace DepiProject.Models
{
    public class InsuranceProvider
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string ContactInfo { get; set; }

        public ICollection<Patient> Patients { get; set; }
    }

}
