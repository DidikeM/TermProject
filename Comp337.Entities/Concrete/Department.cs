using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class Department : IEntity
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Building { get; set; }

    }
}