using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int CourseCredit { get; set; }
        public int SemesterId { get; set; }
    }
}