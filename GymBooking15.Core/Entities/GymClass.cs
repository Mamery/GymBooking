using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBooking15.Core.Entities
{
    public class GymClass
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan Duration { get; set; }
        //public DateTime EndTime { get { return StartTime + Duration; } }
        public DateTime EndTime => StartDate + Duration; 
        public String Description { get; set; }

        public ICollection<ApplicationUserGymClass> AttendingMembers { get; set; }


    }
}
