using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Abstract
{
    public interface IInstructorService
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);    
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
        Instructor GetById(int id); 
        //List<Instructor> GetByCourseId(int courseId);
    }
}