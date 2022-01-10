using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class Course : IEntity
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal CourseCredit { get; set; }
        public int SectionId { get; set; }
        public bool DeleteFlag { get; set; }
    }
}