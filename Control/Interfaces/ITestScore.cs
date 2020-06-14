using System;

namespace Control.Interfaces
{
    interface ITestScore
    {
        int CourseId { get; set; }
        int StudentId { get; set; }
        float StudentScore { get; set; }
        string Comment { get; set; }
        DateTime Date { get; set; }
    }
}
