using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Configuration;
using System.Data; //lägger till denna så det går att använda DBType

namespace Golfklubban
{
    class Methods
    {
       //NYA VERSIONEN
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
                    postalNumber = (int)dr["zipcode"],
                    handicap = (double)dr["handicap"],
                    //  membershipFee = (bool)dr["membershipfee"]
                    //  sex = (bool)dr["sex"],
                };
                playerList.Add(tempPlayer);
            }
            conn.Close();
            return playerList;        
        }
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
                    competitionId = (int)dr["id"],
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
        public static void UpdatePlayer(int golfId, string newFirstName, string newLastName, string newAddress, string newStreetnumber,
          int newZipCode, string newMobile, string newEmail, double newHandicap, int newMembershipStatus, bool newmembershipFee)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[conString];
            NpgsqlConnection conn = new NpgsqlConnection(settings.ConnectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(@"UPDATE player
                                                        SET firstname =:firstName,
                                                            lastname =:lastName,
                                                            playerstatus_id =:membershipStatus,
                                                            address =:address,
                                                            streetnumber =:streetNumber,
                                                            zipcode =:zipCode,
                                                            mobile =:mobilePhone,
                                                            email =:eMail,
                                                            handicap =:handicap,
                                                            membershipfee =:membershipFee
                                                            WHERE golfid = :golfId", conn);
            command.Parameters.Add(new NpgsqlParameter("firstName", DbType.String));
            command.Parameters[0].Value = newFirstName;
            command.Parameters.Add(new NpgsqlParameter("lastName", DbType.String));
            command.Parameters[1].Value = newLastName;
            command.Parameters.Add(new NpgsqlParameter("address", DbType.String));
            command.Parameters[2].Value = newAddress;
            command.Parameters.Add(new NpgsqlParameter("streetNumber", DbType.String));
            command.Parameters[3].Value = newStreetnumber;
            command.Parameters.Add(new NpgsqlParameter("zipCode", DbType.Int32));
            command.Parameters[4].Value = Convert.ToInt32(newZipCode);
            command.Parameters.Add(new NpgsqlParameter("mobilePhone", DbType.String));
            command.Parameters[5].Value = (newMobile);
            command.Parameters.Add(new NpgsqlParameter("eMail", DbType.String));
            command.Parameters[6].Value = newEmail;
            command.Parameters.Add(new NpgsqlParameter("handicap", DbType.Double));
            command.Parameters[7].Value = Convert.ToDouble(newHandicap);
            command.Parameters.Add(new NpgsqlParameter("golfId", DbType.Int32));
            command.Parameters[8].Value = Convert.ToInt32(golfId);
            command.Parameters.Add(new NpgsqlParameter("membershipStatus", DbType.Int32));
            command.Parameters[9].Value = Convert.ToInt16(newMembershipStatus);
            command.Parameters.Add(new NpgsqlParameter("membershipFee", DbType.Boolean));
            command.Parameters[10].Value = newmembershipFee;

            int numberOfRowsAffected = command.ExecuteNonQuery();
            conn.Close();
        }
    } 
}
