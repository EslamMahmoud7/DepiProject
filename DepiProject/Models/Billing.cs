namespace DepiProject.Models
{
    public class Billing
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public string PayMethod { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }

}
