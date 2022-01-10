using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class Student : IEntity
    {
        public int StudentId { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public bool DeleteFlag { get; set; }
    }
}