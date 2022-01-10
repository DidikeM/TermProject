using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.DataAccess.Concrete.EntityFramework
{
    public class EfUserAuthorizationDal : EfEntityRepositoryBase<UserAuthorization, Comp337Context>, IUserAuthorizationDal
    {

    }
}