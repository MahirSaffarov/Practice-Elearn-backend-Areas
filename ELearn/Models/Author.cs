namespace ELearn.Models
{
    public class Author :BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Course> Courses  { get; set; }
    }
}
