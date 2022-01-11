using System.Collections.Generic;
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
    }
}