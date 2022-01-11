using System.ComponentModel.DataAnnotations;
using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class CourseRegistration:IEntity
    {
        //[Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
    }
}
