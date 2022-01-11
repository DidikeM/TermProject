using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class Semester : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
