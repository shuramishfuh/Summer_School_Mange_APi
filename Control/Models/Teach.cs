using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Control.Interfaces;

namespace Control.Models
{
   public class Teach : ITeach
    {
        public short TeachId { get; set; }
        [Required]
        public short CourseId { get; set; }
        public IList<Tutor> Tutors { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime year { get; set; }
    }
}
