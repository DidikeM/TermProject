using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class CourseInstructor : IEntity
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }

    }
}