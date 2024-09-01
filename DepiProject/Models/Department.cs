namespace DepiProject.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Nurse> Nurses { get; set; }
        public ICollection<Service> Services { get; set; }
    }

}
