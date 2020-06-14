using System.ComponentModel.DataAnnotations;
using Control.Interfaces;

namespace Control.Models
{
    public class Tutor : ITutor
    {
        public short TutorId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Name Should be minimum 10 characters and a maximum of 150 characters")]
        public string TutorName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Type cannot be null")]
        public string Type { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(7, MinimumLength = 1, ErrorMessage = "Tell Cannot be null")]
        public string Tel { get; set; }
        [Required (ErrorMessage = "email cannot be null")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(7, MinimumLength = 1, ErrorMessage = "Sex Should be minimum 1 characters and a maximum of 7 characters")]
        public char Sex { get; set; }
    }
}
