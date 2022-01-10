using Comp337.Entities.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {

    }
}