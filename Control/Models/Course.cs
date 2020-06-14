using System.ComponentModel.DataAnnotations;

namespace Control.Models
{
 public   class Course :ICourse
    {
        public short CourseId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Name Should be minimum 5 characters and a maximum of 100 characters")]
        public string CourseName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(2000, MinimumLength = 20, ErrorMessage = "Name Should be minimum 20 characters and a maximum of 2000 characters")]
        public string CourseDescription { get; set; }
    }
}
