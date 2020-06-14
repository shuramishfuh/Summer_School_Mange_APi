using System;
using System.Collections.Generic;
using Control.Models;

namespace Control.Interfaces
{
    interface ITeach
    {
        short TeachId { get; set; }
        short CourseId { get; set; }
        IList<Tutor> Tutors { get; set; }
        DateTime year { get; set; }
    }
}
