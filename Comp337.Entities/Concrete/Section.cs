using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class Section : IEntity
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public int DepartmentTeacherId { get; set; }
        public bool DeleteFlag { get; set; }
    }
}