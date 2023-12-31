﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// The unique identifier for the team
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the Team
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// List of all members of the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); //Instantiate List


        public TeamModel()
        {
            //Instantiate List
            //TeamMembers = new List<Person>();
        }
    }
}
