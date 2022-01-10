using System;
using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class TimeSlot : IEntity
    {
        public int TimeSlotId { get; set; }
        public DateTime Day { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool DeleteFlag { get; set; }

    }
}