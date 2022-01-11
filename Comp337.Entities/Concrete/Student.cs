using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}