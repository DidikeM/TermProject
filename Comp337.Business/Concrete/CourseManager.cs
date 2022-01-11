using System.Collections.Generic;
using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }


        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void update(Course course)
        {
            _courseDal.Update(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }
    }
}