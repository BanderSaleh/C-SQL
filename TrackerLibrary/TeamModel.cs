using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();//Initialize our new List
        public string TeamName { get; set; }


        
        
    }
}
