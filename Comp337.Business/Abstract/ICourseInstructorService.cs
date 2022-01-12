using System.Collections.Generic;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Abstract
{
    public interface ICourseInstructorService
    {
        List<CourseInstructor> GetByCourseId(int courseId);
        void Add(CourseInstructor courseInstructor);
        bool ControlByCourseIdandInstructorId(CourseInstructor courseInstructor);
        void DeleteByCourseIdandInstructorId(CourseInstructor courseInstructor);
        List<CourseInstructor> GetByInstructorId(int id);   
    }
}