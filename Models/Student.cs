using System.ComponentModel.DataAnnotations;

namespace MyWebNetCore.Models
{
    public class Student
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public string Avatar { get; set; }
    }
}