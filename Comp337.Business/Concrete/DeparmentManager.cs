using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;

namespace Comp337.Business.Concrete
{
    public class DeparmentManager :IDepartmentService
    {
        private IDepartmentDal _departmentDal;

        public DeparmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }
    }
}