using System.ComponentModel.DataAnnotations;

namespace StudentApp
{
    public class Student
    {
        // Primary key for the Student entity
        [Key]
        public int Id { get; set; }
        
        // Student's name
        public string Name { get; set; }
    }
}