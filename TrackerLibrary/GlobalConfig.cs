﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModel.csv";
        public const string MatchupFile = "MatchupModel.csv";
        public const string MatchupEntryFile = "MatchupEntryModel.csv";
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {

            if (db == DatabaseType.Sql)
            {
                //TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            else if (db == DatabaseType.Textfile)
            {
                //TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
