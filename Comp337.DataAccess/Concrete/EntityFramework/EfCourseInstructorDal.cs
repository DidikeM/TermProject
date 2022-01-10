using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.DataAccess.Concrete.EntityFramework
{
    public class EfCourseInstructorDal : EfEntityRepositoryBase<CourseInstructor, Comp337Context>, ICourseInstructorDal
    {

    }
}