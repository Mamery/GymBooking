using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBooking15.Core.Entities
{
    public class ApplicationUserGymClass
    {
        //om vi ladda ned den heär tabellen 
        //vi får information nedan
        public int GymClassId { get; set; } //foreign key 1 ---- alla rader med gympass id 1 for eksampel 

        public string ApplicationUserId { get; set; } //använd nyckel som string

        //NavigationProperties

        public GymClass GymClass { get; set; } //Includ om det behöves plukkar rad med primaär nyckel 1


        public ApplicationUser ApplicationUser { get; set; }

    }
}
