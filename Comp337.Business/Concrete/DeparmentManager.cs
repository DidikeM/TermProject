using System.Collections.Generic;
using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Concrete
{
    public class DeparmentManager :IDepartmentService
    {
        private IDepartmentDal _departmentDal;

        public DeparmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public List<Department> GetAll()
        {
            return _departmentDal.GetAll();
        }
    }
}