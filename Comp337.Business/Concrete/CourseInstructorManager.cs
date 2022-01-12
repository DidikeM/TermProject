using System.Collections.Generic;
using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Concrete
{
    public class CourseInstructorManager :ICourseInstructorService
    {
        private ICourseInstructorDal _courseInstructorDal;

        public CourseInstructorManager(ICourseInstructorDal courseInstructorDal)
        {
            _courseInstructorDal = courseInstructorDal;
        }


        public List<CourseInstructor> GetByCourseId(int courseId)
        {
            return _courseInstructorDal.GetAll(p => p.CourseId == courseId);
        }
    }
}