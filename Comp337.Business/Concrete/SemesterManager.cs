using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;
using System.Collections.Generic;

namespace Comp337.Business.Concrete
{
    public class SemesterManager : ISemesterService
    {
        private ISemesterDal _semesterDal;

        public SemesterManager(ISemesterDal semesterDal)
        {
            _semesterDal = semesterDal;
        }

        public List<Semester> GetAll()
        {
            return _semesterDal.GetAll();
        }

        public Semester GetById(int id)
        {
            return _semesterDal.Get(p => p.Id == id);
        }
    }
}