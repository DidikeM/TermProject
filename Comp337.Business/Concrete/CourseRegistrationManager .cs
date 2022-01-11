using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;

namespace Comp337.Business.Concrete
{
    public class CourseRegistrationManager : ICourseRegistrationService
    {
        private ICourseRegistrationDal _courseRegistrationDal;

        public CourseRegistrationManager(ICourseRegistrationDal courseRegistrationDal)
        {
            _courseRegistrationDal = courseRegistrationDal;
        }


    }
}