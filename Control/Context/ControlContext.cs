using Control.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.Context
{
    public class ControlContext :DbContext
    {
        public ControlContext()
        {
        }

        public ControlContext(DbContextOptions<ControlContext> options) : base(options)
        {
          
            
            
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<ApiKey> ApiKeys { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teach> Teaches { get; set; }
        public DbSet<TestScore> TestScores { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
   

        
    } 
}
