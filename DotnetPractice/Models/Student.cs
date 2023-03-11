using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetPractice.Models
{
    [Table("student")]
    public class Student
    {
        [Column("id")]
        public int ID { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("first_mid_name")]
        public string FirstMidName { get; set; }

        [Column("enrollment_date")]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
