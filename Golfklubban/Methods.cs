using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Configuration;

namespace Golfklubban
{
    class Methods
    {
        public const string conString = "MIUN";
        
        //***Hämtar spelare***
        public static List<Player> GetPlayers()
        {
            List<Player> playerList = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString]; 
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("SELECT * FROM player ORDER BY firstname", conn);
            NpgsqlDataReader dr = command1.ExecuteReader();
              while(dr.Read())              
              {
                  Player tempPlayer = new Player{golfId = (int)dr["golfId"], firstName = (string)dr["firstname"], lastName = (string)dr["lastName"]};
                  playerList.Add(tempPlayer);
              }
            conn.Close();
            return playerList;            
        }                                          
    } 
}
