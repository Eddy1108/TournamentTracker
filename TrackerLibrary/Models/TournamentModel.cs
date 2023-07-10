using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// unique identifier for tournament
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// The amount of money each team needs to pay to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List of all teams entered into the tounrnament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of all Prizes for various places
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// The matchups per round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
