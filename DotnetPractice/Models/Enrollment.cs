using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetPractice.Models
{
    
    public enum Grade
    {
        A, B, C, D, F
    }

    [Table("enrollment")]
    public class Enrollment
    {
        [Column("enrollment_id")]
        public int EnrollmentID { get; set; }

        [Column("course_id")]
        public int CourseID { get; set; }

        [Column("student_id")]
        public int StudentID { get; set; }

        [Column("grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
