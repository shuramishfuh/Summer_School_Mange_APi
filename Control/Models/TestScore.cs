using System;
using System.ComponentModel.DataAnnotations;
using Control.Interfaces;

namespace Control.Models
{
    public class TestScore : ITestScore
    {
        [Required(ErrorMessage = "course Id cannot be empty")]
        public int CourseId { get; set; }
        public int TestScoreId { get; set; }
        [Required(ErrorMessage = "student id cannot be empty")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "score cannot be empty")]
        [Range(0, 100, ErrorMessage = "score cannot be empty")]
        public float StudentScore { get; set; }
        [DataType(DataType.Text)]
        [StringLength(1000, MinimumLength = 0, ErrorMessage = "Name Should be minimum 0 characters and a maximum of 1000 characters")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "date cannot be null")]
        public DateTime Date { get; set; }
    }
}
