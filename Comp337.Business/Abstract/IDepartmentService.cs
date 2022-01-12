using System.Collections.Generic;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
        Department GetById(int id);
    }
}