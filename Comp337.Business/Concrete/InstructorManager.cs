using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;

namespace Comp337.Business.Concrete
{
    public class InstructorManager :IInstructorService
    {
        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }


    }
}