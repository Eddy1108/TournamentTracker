using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// List of all members of the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); //Instantiate List
        
        /// <summary>
        /// Name of the Team
        /// </summary>
        public string TeamName { get; set; }

        public TeamModel()
        {
            //Instantiate List
            //TeamMembers = new List<Person>();
        }
    }
}
