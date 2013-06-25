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
        
        
        public static List<Player> GetPlayers() //hämtar alla spelare i databasen
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
        public static List<Player> GetNotGuestPlayers() //hämtar alla spelare i databasen
        {
            List<Player> playerList = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("SELECT * FROM player WHERE playerstatus_id <= 4 ORDER BY firstname", conn);
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
        public static List<Competition> GetSingleCompetitions() //hämtar alla tävlingar framåt i tiden
        {
            List<Competition> competitionList = new List<Competition>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM competition WHERE enddate >= NOW() AND competition.competitiontype = 1", conn);
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
        public static List<Competition> GetCoupleCompetitions() //hämtar alla tävlingar framåt i tiden
        {
            List<Competition> competitionList = new List<Competition>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM competition WHERE enddate >= NOW() AND competition.competitiontype = 2", conn);
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
        public static List<Competition> GetTeamCompetitions() //hämtar alla tävlingar framåt i tiden
        {
            List<Competition> competitionList = new List<Competition>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM competition WHERE enddate >= NOW() AND competition.competitiontype = 3", conn);
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


        public static List<Competition> GetPassedCompetitions() //hämtar gamla tävlingar
        {
            List<Competition> competitionList = new List<Competition>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM competition WHERE enddate <= NOW()", conn);
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

        public static List<Team> GetTeams() //hämtar alla lag
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

        public static List<Couple> GetCouples() //hämtar alla par
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
            NpgsqlCommand command1 = new NpgsqlCommand("SELECT * FROM player WHERE playerstatus_id  < 5 AND team_id IS null ORDER BY firstname", conn);
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
                   
                };
                playerList.Add(tempPlayer);
            }
            conn.Close();
            return playerList;
        }

        public static List<Player> GetAvailablePlayersToCouple() //hämtar endast spelare som inte har något par
        {
            List<Player> playerList = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command1 = new NpgsqlCommand("SELECT * FROM player WHERE playerstatus_id  < 5 AND couple_id IS null ORDER BY firstname", conn);
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
                };
                playerList.Add(tempPlayer);
            }
            conn.Close();
            return playerList;
        }
        public static List<Player> SearchPlayer(int golfId)
        {
            List<Player> foundPlayer = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(@"SELECT * 
                                                        FROM player 
                                                        WHERE golfid =:golfId
                                                        ", conn);
            command.Parameters.Add(new NpgsqlParameter("golfId", DbType.Int32));
            command.Parameters[0].Value = Convert.ToInt32(golfId);

            NpgsqlDataReader dr = command.ExecuteReader();
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
                foundPlayer.Add(tempPlayer);
            }
            conn.Close();
            return foundPlayer;
        }

        public static List<string> GetTimeIntervals() //metod som skapar tid med tio min mellanrun 08:00, 08:10 osv
        {
            List<string> timeIntervals = new List<string>();
            TimeSpan startTime = new TimeSpan(4, 00, 00);
            for (int i = 0; i < 60; i++)
            {
                int minutesToBeAdded = 10 * i;      
                TimeSpan timeToBeAdded = new TimeSpan(0, minutesToBeAdded, 0);
                TimeSpan t = startTime.Add(timeToBeAdded);
                TimeSpan result = startTime + t;
                timeIntervals.Add(result.ToString());                     
            }
            return timeIntervals;
        }

        public static List<Player> GetBookedPlayers(DateTime selectedDate, string selectedTime)
        {
            List<Player> bookedPlayers = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(@"SELECT golfid,firstname,lastname, handicap 
                                                        FROM player 
                                                        INNER JOIN golfround ON player.golfid
                                                        = golfround.player
                                                        where date =:selectedDate
                                                        AND
                                                        startingtime =:selectedTime", conn);

            command.Parameters.Add(new NpgsqlParameter("selectedDate", DbType.Date));
            command.Parameters[0].Value = Convert.ToDateTime(selectedDate);
            command.Parameters.Add(new NpgsqlParameter("selectedTime", DbType.String));
            command.Parameters[1].Value = Convert.ToString(selectedTime);

            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Player players = new Player
                {
                    golfId = (int)dr["golfid"],
                    firstName = (string)dr["firstname"],
                    lastName = (string)dr["lastname"],
                    handicap = (double)dr["handicap"]

                };
                bookedPlayers.Add(players);
            }
            conn.Close();
            return bookedPlayers;
        }

        public static List<Player> SearchPlayerByLastName(string lastName)
        {
            List<Player> foundPlayer = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(@"SELECT * 
                                                        FROM player 
                                                        WHERE lastname =:lastName
                                                        ", conn);
            command.Parameters.Add(new NpgsqlParameter("lastname", DbType.String));
            command.Parameters[0].Value = lastName;

            NpgsqlDataReader dr = command.ExecuteReader();
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
                foundPlayer.Add(tempPlayer);
            }
            conn.Close();
            return foundPlayer;
        }
        public static List<Player> GetUnbookedPlayers(DateTime selectedDate, string selectedTime)
        {
            List<Player> unBookedPlayers = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(@"SELECT golfid,firstname,lastname,handicap 
                                                        FROM player
                                                        WHERE golfid not in (
                                                        SELECT player 
                                                        FROM golfround 
                                                        WHERE player.golfid = golfround.player
                                                        AND date =:selectedDate
                                                        AND startingtime =:selectedTime )", conn);

            command.Parameters.Add(new NpgsqlParameter("selectedDate", DbType.Date));
            command.Parameters[0].Value = Convert.ToDateTime(selectedDate);
            command.Parameters.Add(new NpgsqlParameter("selectedTime", DbType.String));
            command.Parameters[1].Value = Convert.ToString(selectedTime);

            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Player players = new Player
                {
                    golfId = (int)dr["golfid"],
                    firstName = (string)dr["firstname"],
                    lastName = (string)dr["lastname"],
                    handicap = (double)dr["handicap"]

                };
                unBookedPlayers.Add(players);
            }
            conn.Close();
            return unBookedPlayers;
        }
        public static List<Maintenance> GetUpcomingMaintenance() //hämtar alla kommande underhåll
        {
            List<Maintenance> maintenanceList = new List<Maintenance>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT id, date, startingtime, endtime FROM golfround WHERE date >= NOW() AND staff_id IS NOT null ORDER BY date", conn);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Maintenance maintenances = new Maintenance
                {
                    maintenanceId = (int)dr["id"],
                    maintenanceDate = (DateTime)dr["date"],
                    maintenanceStart = (string)dr["startingtime"],
                    maintenanceEnd = (string)dr["endtime"],

                };
                maintenanceList.Add(maintenances);
            }
            conn.Close();
            return maintenanceList;
        }

        public static List<Player> GetPlayersInCompetition(int selectedCompetitionId)
        {
            List<Player> competitionsPlayers = new List<Player>();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(@"SELECT firstname,lastname
                                                        FROM player 
                                                        JOIN player_competition ON player.golfid
                                                        = player_competition.player_id
                                                        where player_competition.competition_id =:selectedCompetitionId", conn);

            command.Parameters.Add(new NpgsqlParameter("selectedCompetitionId", DbType.Int32));
            command.Parameters[0].Value = Convert.ToInt32(selectedCompetitionId);


            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Player players = new Player
                {
                    firstName = (string)dr["firstname"],
                    lastName = (string)dr["lastname"]

                };
                competitionsPlayers.Add(players);
            }
            conn.Close();
            return competitionsPlayers;
        }
    } 
}
