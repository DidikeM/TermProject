using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;

namespace Comp337.Business.Concrete
{
    public class ClassroomManager : IClassroomService
    {
        private IClassroomDal _classroomDal;

        public ClassroomManager(IClassroomDal classroomDal)
        {
            _classroomDal = classroomDal;
        }
    }
}