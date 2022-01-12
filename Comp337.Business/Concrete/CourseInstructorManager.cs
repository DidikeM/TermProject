using System;
using System.Collections.Generic;
using System.Threading;
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


        public List<CourseInstructor> GetByCourseId(int id)
        {
            return _courseInstructorDal.GetAll(p => p.CourseId == id);
        }

        public List<CourseInstructor> GetByInstructorId(int id)
        {
            return _courseInstructorDal.GetAll(p => p.InstructorId == id);
        }

        public void Add(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Add(courseInstructor);
        }

        public bool ControlByCourseIdandInstructorId(CourseInstructor courseInstructor)
        {
            //Todo Eğer gönderilen değer varsa true yoksa false dödürür
            if (_courseInstructorDal.Get(p=>p.CourseId == courseInstructor.CourseId && p.InstructorId == courseInstructor.InstructorId) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteByCourseIdandInstructorId(CourseInstructor courseInstructor)
        {
            var a = _courseInstructorDal.Get(p => p.CourseId == courseInstructor.CourseId && p.InstructorId == courseInstructor.InstructorId);
            if (a != null)
            {
                _courseInstructorDal.Delete(a);
            }
            else
            {

            }
        }
    }
}