using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// First Name of Person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last Name of Person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email belonging to Person
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// Cellphone number belonging to Person
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}
