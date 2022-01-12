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

        public List<CourseRegistration> GetByCourseId(int id)
        {
            return _courseRegistrationDal.GetAll(p => p.CourseId == id);
        }

        public bool ControlByStudentIdandCourseId(CourseRegistration courseRegistration)
        {
            //Todo Eğer gönderilen değer varsa true yoksa false dödürür
            if (_courseRegistrationDal.Get(p => p.StudentId == courseRegistration.StudentId && p.CourseId == courseRegistration.CourseId) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteByStudentIdandCourseId(CourseRegistration courseRegistration)
        {
            var a = _courseRegistrationDal.Get(p => p.StudentId == courseRegistration.StudentId && p.CourseId == courseRegistration.CourseId);
            if (a != null)
            {
                _courseRegistrationDal.Delete(a);
            }
            else
            {

            }
        }

        public void Add(CourseRegistration courseRegistration)
        {
            _courseRegistrationDal.Add(courseRegistration);
        }
    }
}