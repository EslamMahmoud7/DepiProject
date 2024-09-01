namespace DepiProject.Models
{
    public class Nurse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public int DepartmentID { get; set; }

        public Department Department { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }

}
