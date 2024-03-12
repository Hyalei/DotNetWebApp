using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetWebApp.Entity
{
    [Table(nameof(Student))]
    public class Student
    {
        [Key]
        public string Guid { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        public override string ToString()
        {
            return "Guid: "+Guid + Environment.NewLine+
                "Name: "+ Name + Environment.NewLine+
                "Age: "+ Age + Environment.NewLine;
        }
    }
}
