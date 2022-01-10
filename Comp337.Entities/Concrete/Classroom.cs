using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class Classroom :IEntity
    {
        public int ClassroomId { get; set; }
        public string RoomNumber { get; set; }
        public bool DeleteFlag { get; set; }

    }
}