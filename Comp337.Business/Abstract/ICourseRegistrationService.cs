using System.Collections.Generic;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Abstract
{
    public interface ICourseRegistrationService
    {
        List<CourseRegistration> GetByStudentId(int id);
        bool ControlByStudentIdandCourseId(CourseRegistration courseRegistration);
        void DeleteByStudentIdandCourseId(CourseRegistration courseRegistration);
        void Add(CourseRegistration courseRegistration);
        List<CourseRegistration> GetByCourseId(int id);
    }
}