namespace DepiProject.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public ICollection<Department> Departments { get; set; }
    }

}
