using System.Collections.Generic;
using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Concrete
{
    public class AdvisorManager : IAdvisorService
    {
        private IAdvisorDal _advisorDal;

        public AdvisorManager(IAdvisorDal advisorDal)
        {
            _advisorDal = advisorDal;
        }
        
        public List<Advisor> GetByInstructoreId(int instructoId)
        {
            return _advisorDal.GetAll(p => p.InstructorId == instructoId);
        }

        public bool ControlByStudentIdandInstructorId(Advisor advisor)
        {
            //Todo Eğer gönderilen değer varsa true yoksa false dödürür
            if (_advisorDal.Get(p => p.StudentId == advisor.StudentId && p.InstructorId == advisor.InstructorId) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Add(Advisor advisor)
        {
            _advisorDal.Add(advisor);
        }
    }
}