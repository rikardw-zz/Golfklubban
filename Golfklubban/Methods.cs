using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Configuration;
using System.Data;

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
            while (dr.Read())
            {
                Player tempPlayer = new Player
                {
                    golfId = (int)dr["golfId"],
                    membershipStatus = (int)dr["playerstatus_id"],
                    firstName = (string)dr["firstname"],
                    lastName = (string)dr["lastname"],
                    streetNumber = (string)dr["streetnumber"],
                    mobilePhone = (string)dr["mobile"],
                    address = (string)dr["address"],
                    eMail = (string)dr["email"],
                    zipCode = (int)dr["zipcode"],
                    handicap = (double)dr["handicap"],
                    membershipFee = (bool)dr["membershipfee"],
                    sex = (bool)dr["sex"]
                };
                playerList.Add(tempPlayer);
            }
            conn.Close();
            return playerList;        
        }

        //***Hämtar Tävlingar***
        public static List<Competition> GetCompetitions()
        {
            List<Competition> competitionList = new List<Competition>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM competition ORDER BY startdate", conn);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Competition competitions = new Competition
                {
                    Id = (int)dr["id"],
                    competitionName = (string)dr["name"],
                    startDate = (DateTime)dr["startdate"],
                    endDate = (DateTime)dr["enddate"],
                    lastBookingDate = (DateTime)dr["lastbookingdate"],
                    lastUnbookingDate = (DateTime)dr["lastunbookingdate"],
                    classA = (double)dr["classa"],
                    classB = (double)dr["classb"],
                    classC = (double)dr["classc"]
                };
                competitionList.Add(competitions);
            }
            conn.Close();
            return competitionList;
        }
    
        public static List<Player> GetPlayerInTeam(int teamID) //hämtar spelare från markerat lag
        {
            List<Player> playerInTeamList = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(@"SELECT * 
                                                        FROM player 
                                                        WHERE team_id =:teamID ORDER BY lastname", conn);

            command.Parameters.Add(new NpgsqlParameter("teamID", DbType.Int32));
            command.Parameters[0].Value = Convert.ToInt32(teamID);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Player players = new Player
                {
                    golfId = (int)dr["golfid"],
                    firstName = (string)dr["firstname"],
                    lastName = (string)dr["lastname"],
                    teamId = (int)dr["team_id"]
                };
                playerInTeamList.Add(players);
            }
            conn.Close();
            return playerInTeamList;
        }

        public static List<Team> GetTeams()
        {
            List<Team> teamList = new List<Team>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM team ORDER BY name", conn);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Team teams = new Team
                {
                    teamId = (int)dr["id"],
                    teamName = (string)dr["name"],
                };
                teamList.Add(teams);
            }
            conn.Close();
            return teamList;
        }

        public static List<Player> GetPlayerInCouple(int coupleID) //hämtar spelare från markerat par
        {
            List<Player> playerInCoupleList = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(@"SELECT * 
                                                        FROM player 
                                                        WHERE couple_id =:coupleID ORDER BY lastname", conn);

            command.Parameters.Add(new NpgsqlParameter("coupleID", DbType.Int32));
            command.Parameters[0].Value = Convert.ToInt32(coupleID);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Player players = new Player
                {
                    golfId = (int)dr["golfid"],
                    firstName = (string)dr["firstname"],
                    lastName = (string)dr["lastname"],
                    coupleId = (int)dr["couple_id"]
                };
                playerInCoupleList.Add(players);
            }
            conn.Close();
            return playerInCoupleList;
        }

        public static List<Couple> GetCouples()
        {
            List<Couple> coupleList = new List<Couple>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM couple ORDER BY name", conn);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Couple couples = new Couple
                {
                    coupleId = (int)dr["id"],
                    coupleName = (string)dr["name"],
                };
                coupleList.Add(couples);
            }
            conn.Close();
            return coupleList;
        }

        public static List<Player> GetAvailablePlayers() //hämtar endast spelare som inte har något team
        {
            List<Player> playerList = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("SELECT * FROM player WHERE team_id IS null ORDER BY firstname", conn);
            NpgsqlDataReader dr = command1.ExecuteReader();
            while (dr.Read())
            {
                Player tempPlayer = new Player
                {
                    golfId = (int)dr["golfId"],
                    membershipStatus = (int)dr["playerstatus_id"],
                    firstName = (string)dr["firstname"],
                    lastName = (string)dr["lastname"],
                    streetNumber = (string)dr["streetnumber"],
                    mobilePhone = (string)dr["mobile"],
                    address = (string)dr["address"],
                    eMail = (string)dr["email"],
                    zipCode = (int)dr["zipcode"],
                    handicap = (double)dr["handicap"],
                    //  membershipFee = (bool)dr["membershipfee"]
                    //  sex = (bool)dr["sex"],
                };
                playerList.Add(tempPlayer);
            }
            conn.Close();
            return playerList;
        }

        /*public static List<Player> GetAvailablePlayers() //hämtar endast spelare som inte har något par
        {
            List<Player> playerList = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("SELECT * FROM player WHERE couple_id IS null ORDER BY firstname", conn);
            NpgsqlDataReader dr = command1.ExecuteReader();
            while (dr.Read())
            {
                Player tempPlayer = new Player
                {
                    golfId = (int)dr["golfId"],
                    membershipStatus = (int)dr["playerstatus_id"],
                    firstName = (string)dr["firstname"],
                    lastName = (string)dr["lastname"],
                    streetNumber = (string)dr["streetnumber"],
                    mobilePhone = (string)dr["mobile"],
                    address = (string)dr["address"],
                    eMail = (string)dr["email"],
                    zipCode = (int)dr["zipcode"],
                    handicap = (double)dr["handicap"],
                    //  membershipFee = (bool)dr["membershipfee"]
                    //  sex = (bool)dr["sex"],
                };
                playerList.Add(tempPlayer);
            }
            conn.Close();
            return playerList;
        }*/
    } 

}
