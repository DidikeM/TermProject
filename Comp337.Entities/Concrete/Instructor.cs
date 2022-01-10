using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class Instructor : IEntity
    {
        public int InstructorId { get; set; }
        public int NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool DeleteFlag { get; set; }

    }
}