using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class CourseInstructor : IEntity
    {
        public int CourseInstructorId { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public bool DeleteFlag { get; set; }

    }
}