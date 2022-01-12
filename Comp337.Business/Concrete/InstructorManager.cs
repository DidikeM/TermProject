using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Concrete
{
    public class InstructorManager :IInstructorService
    {
        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        
        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.Get(p => p.Id == id);
        }

    }
}