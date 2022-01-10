using System.Collections.Generic;
using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;

        

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }
    }
}