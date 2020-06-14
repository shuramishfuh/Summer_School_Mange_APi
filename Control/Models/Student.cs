using System;
using System.ComponentModel.DataAnnotations;
using Control.Interfaces;


namespace Control.Models
{
 public   class Student : IStudent
    {
        public short StudentId { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Name Should be minimum 10 characters and a maximum of 150 characters")]
        public string Name { get ; set ; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(7, MinimumLength = 1, ErrorMessage = "Sex Should be minimum 1 characters and a maximum of 6 characters")]
        public string Sex { get ; set ; }
        [Required]
        [Range(12,100)]
        public short Age { get ; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "School Should be minimum 3 characters and a maximum of 300 characters")]
        public string School { get ; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "FutureCareer Should be minimum 5 characters and a maximum of 40 characters")]
        public string FutureCareerChoice { get; set; }

        public byte GceOLevels { get ; set ; }
        public byte GceALevels { get; set ; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "UserName Should be minimum 5 characters and a maximum of 50 characters")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(70, MinimumLength = 10, ErrorMessage = "password Should be minimum 10 characters and a maximum of 70 characters")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(17, MinimumLength = 9, ErrorMessage = "Name Should be minimum 1 characters and a maximum of 6 characters")]
        public string Tel { get; set; }
        [Required(ErrorMessage = "date cannot be empty")]
        [DataType(DataType.Date)]
        public DateTime YearOfAttendance { get; set; }
    }
}
