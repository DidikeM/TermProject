using System.Collections.Generic;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);
    }
}