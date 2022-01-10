using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.DataAccess.Concrete.EntityFramework
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, Comp337Context>, IStudentDal
    {

    }
}