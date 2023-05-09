using System.ComponentModel.DataAnnotations;

namespace task.Models
{
    public class Person
    {
        public  int Id { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
    }
}
