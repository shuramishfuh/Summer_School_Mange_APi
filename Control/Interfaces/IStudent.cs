
using System;

namespace Control.Interfaces
{
    interface IStudent
    {
        short StudentId { get; set; }
        string Name { get; set; }

        string Sex { get; set; }
        short Age { get; set; }
        string School { get; set; }
        string FutureCareerChoice { get; set; }
        byte GceOLevels { get; set; }
        byte GceALevels { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Tel { get; set; }
        DateTime YearOfAttendance { get; set; }






    }
}
