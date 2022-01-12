using System.Collections.Generic;
using Comp337.Entities.Concrete;

namespace Comp337.Business.Abstract
{
    public interface IAdvisorService
    {
        List<Advisor> GetByInstructoreId(int instructoId);
        bool ControlByStudentIdandInstructorId(Advisor advisor);
        void Add(Advisor advisor);
        void DeleteByStudentIdandInstructorId(Advisor advisor);
        bool ControlByStudentId(Advisor advisor);
    }
}