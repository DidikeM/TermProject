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

        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public Student GetById(int id)
        {
            return _studentDal.Get(p => p.Id == id);
        }
    }
}