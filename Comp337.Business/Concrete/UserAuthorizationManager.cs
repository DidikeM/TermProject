using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;

namespace Comp337.Business.Concrete
{
    public class UserAuthorizationManager : IUserAuthorizationService
    {
        private IUserAuthorizationDal _userAuthorizationDal;

        public UserAuthorizationManager(IUserAuthorizationDal userAuthorizationDal)
        {
            _userAuthorizationDal = userAuthorizationDal;
        }
    }
}