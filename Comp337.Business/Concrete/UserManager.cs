using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;

namespace Comp337.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
    }
}