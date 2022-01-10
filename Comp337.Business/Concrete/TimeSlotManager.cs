using Comp337.Business.Abstract;
using Comp337.DataAccess.Abstract;

namespace Comp337.Business.Concrete
{
    public class TimeSlotManager : ITimeSlotService
    {
        private ITimeSlotDal _timeSlotDal;

        public TimeSlotManager(ITimeSlotDal timeSlotDal)
        {
            _timeSlotDal = timeSlotDal;
        }
    }
}