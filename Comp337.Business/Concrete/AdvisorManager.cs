using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;

namespace Comp337.Business.Concrete
{
    public class AdvisorManager : IAdvisorService
    {
        private IAdvisorDal _advisorDal;

        public AdvisorManager(IAdvisorDal advisorDal)
        {
            _advisorDal = advisorDal;
        }


    }
}