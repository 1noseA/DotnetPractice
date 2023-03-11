using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetPractice.Models
{
    [Table("course")]
    public class Course
    {
        [Column("course_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("credits")]
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
