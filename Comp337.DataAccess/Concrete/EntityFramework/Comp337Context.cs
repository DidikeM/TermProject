using System.Data.Entity;
using Comp337.Entities.Concrete;

namespace Comp337.DataAccess.Concrete.EntityFramework
{
    public class Comp337Context : DbContext
    {
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
        public DbSet<CourseRegistration> CourseRegistrations { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAuthorization> UserAuthorizations { get; set; }

    }
}