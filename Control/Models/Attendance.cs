using System;
using System.ComponentModel.DataAnnotations;
using Control.Interfaces;

namespace Control.Models
{
   public class Attendance :IAttendance
    {
        public short AttendanceId { get; set; }
        [Required]
        public short StudentId { get; set; }
        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Date can not be empty") ]
        public DateTime Date { get; set; }
    }
}
