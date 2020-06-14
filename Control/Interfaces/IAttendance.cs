using System;

namespace Control.Interfaces
{
    interface IAttendance
    {
        short AttendanceId { get; set; }
        short StudentId { get; set; }
        DateTime Date { get; set; }
    }
}
