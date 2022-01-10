using System.Collections.Generic;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
    }
}