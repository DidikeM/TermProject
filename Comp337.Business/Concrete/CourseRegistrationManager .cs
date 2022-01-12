using System.Collections.Generic;
using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Concrete
{
    public class CourseRegistrationManager : ICourseRegistrationService
    {
        private ICourseRegistrationDal _courseRegistrationDal;

        public CourseRegistrationManager(ICourseRegistrationDal courseRegistrationDal)
        {
            _courseRegistrationDal = courseRegistrationDal;
        }

        public List<CourseRegistration> GetByStudentId(int id)
        {
            return _courseRegistrationDal.GetAll(p => p.StudentId == id);
        }
    }
}