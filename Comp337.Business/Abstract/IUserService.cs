using Comp337.Entities.Concrete;

namespace Comp337.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Delete(User user);
        User GetByUsername(User user);
        void Update(User user);
    }
}