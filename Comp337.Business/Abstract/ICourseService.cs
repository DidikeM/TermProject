using System.Collections.Generic;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Abstract
{
    public interface ICourseService
    {
        void Add(Course course);
        List<Course> GetAll();
        void update(Course course);
        void Delete(Course course);
    }
}