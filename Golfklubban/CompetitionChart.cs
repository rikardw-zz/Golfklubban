using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;


namespace Golfklubban
{
    public partial class CompetitionChart : Form
    {
        Team selectedTeam = new Team();
        Player selectedPlayer = new Player();
        Competition selectedCompetition = new Competition();
        Couple selectedCouple = new Couple();

        public CompetitionChart()
        {
            InitializeComponent();
            lbPlayers.DataSource = Methods.GetAvailablePlayers();
            lbTeamChart.DataSource = Methods.GetTeams();
            lbPlayers2.DataSource = Methods.GetAvailablePlayersToCouple();
            lbCoupleChart.DataSource = Methods.GetCouples();
            lbPassedCompetitionChart.DataSource = Methods.GetPassedCompetitions();
            lbSinglePlayers.DataSource = Methods.GetNotGuestPlayers();            
            
        }
        private void btnRegisterCompetition_Click(object sender, EventArgs e)
        {
            DateTime dayNow = DateTime.Today;
            if (Convert.ToDateTime(txtStartDate.Text) > dayNow)
            {
                addCompetition();
            }
            else 
            {
                MessageBox.Show("Du kan inte registrera ett datum som redan passerat");
            }
        }
        private void addCompetition()
        {
            string name = txtCompetitionName.Text;
            DateTime startDate = Convert.ToDateTime(txtStartDate.Text);
            DateTime endDate = Convert.ToDateTime(txtEndDate.Text);
            DateTime lastBooking = Convert.ToDateTime(txtLastBookingDate.Text);
            DateTime lastUnbooking = Convert.ToDateTime(txtLastBookingDate.Text);
            string classA = txtClassA.Text;
            string classB = txtClassB.Text;
            string classC = txtClassC.Text;
            int competitionType = 0;

            if (rbSingel.Checked)
            {
                competitionType = 1;
            }
            else if (rbPar.Checked)
            {
                competitionType = 2;
            }
            else if (rbLag.Checked)
            {
                competitionType = 3;
            }

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true;");
            try
            {
                conn.Open();
                string insert = "INSERT INTO competition (name, startdate, enddate, lastbookingdate, lastunbookingdate, classa, classb, classc, competitiontype) VALUES('" + name + "','" + startDate + "','" + endDate + "','" + lastBooking + "','" + lastUnbooking + "'," + classA + "," + classB + "," + classC + ", " + competitionType + ")";
                NpgsqlCommand command = new NpgsqlCommand(insert, conn);
                //används när man kör INSERT fråga
                int numberOfAffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                lbCompetitionChart.DataSource = Methods.GetSingleCompetitions();
                conn.Close();
            }
            txtCompetitionName.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            txtLastBookingDate.Clear();
            txtLastUnbookingDate.Clear();
            txtClassA.Clear();
            txtClassB.Clear();
            txtClassC.Clear();
        }

        private void DeleteCompetition()
        {
            selectedCompetition = (Competition)lbCompetitionChart.SelectedItem;
            DialogResult dropCompetition = MessageBox.Show("Vill du verkligen ta bort den markerade tävlingen?", "Ta bort tävling", MessageBoxButtons.OKCancel);
            if (dropCompetition == DialogResult.OK)
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true;");
                try
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand(("DELETE FROM competition WHERE competition.id = " + selectedCompetition.Id + ""), conn);

                    int numberOfAffectedRows = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                  
                    conn.Close();
                    MessageBox.Show("Tävlingen är nu borttagen.");
                }
            }
            else if (dropCompetition == DialogResult.Cancel)
            { }
        }

        private void CompetitionChart_Load(object sender, EventArgs e)
        {
            lbCompetitionChart.DataSource = Methods.GetSingleCompetitions();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteCompetition();
        }
        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            if ((txtTeamName.Text.Trim().Length == 0)) //kod som undersöker om det finns någon text i textbox
            { MessageBox.Show("Du måste välja ett namn på laget!"); }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO team (name) VALUES ('" + txtTeamName.Text + "')", conn);
                    int antal = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                lbTeamChart.DataSource = Methods.GetTeams();
                MessageBox.Show("Laget har nu sparats!");
            }
        }
        private void lbTeamChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.Text = Convert.ToString(lbTeamChart.SelectedItem.ToString()) + "";
            selectedTeam = (Team)lbTeamChart.SelectedItem;
            lbPlayerInTeam.DataSource = Methods.GetPlayerInTeam(selectedTeam.teamId);
        }

        private void btnAddPlayerToTeam_Click(object sender, EventArgs e)
        {
            
            for (int x = 0; x < lbPlayerInTeam.Items.Count; x++) //ser till så att inte fler än 4 kan vara med i samma grupp
            {
                lbPlayerInTeam.SetSelected(x, true);
            }
            if (lbPlayerInTeam.Items.Count >= 4)
            {
                MessageBox.Show("Du kan inte lägga till fler spelare");
            }
            else
            {            
                selectedTeam = (Team)lbTeamChart.SelectedItem;            
                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");            
                                  
                selectedPlayer = (Player)lbPlayers.SelectedItem;
                selectedTeam = (Team)lbTeamChart.SelectedItem;
                try
                {
                    conn.Open();
                    NpgsqlCommand command1 = new NpgsqlCommand("UPDATE player SET team_id = " + selectedTeam.teamId + " WHERE golfid = (" + selectedPlayer.golfId + " )", conn);
                    int antal = command1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                lbPlayerInTeam.DataSource = Methods.GetPlayerInTeam(selectedTeam.teamId);
                lbPlayers.DataSource = Methods.GetAvailablePlayers();                              
            }        
        }


//Denna kod låg här tidigare, den fungerar och därför kommenterar jag endast bort den istället för att radera
       /*     selectedPlayer = (Player)lbPlayers.SelectedItem;
            selectedTeam = (Team)lbTeamChart.SelectedItem;

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand("UPDATE player SET team_id = " + selectedTeam.teamId + " WHERE golfid = (" + selectedPlayer.golfId + " )", conn);
                int antal = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }         
            lbPlayerInTeam.DataSource = Methods.GetPlayerInTeam(selectedTeam.teamId);
            lbPlayers.DataSource = Methods.GetAvailablePlayers(); 
        }*/

        private void btnDeletePlayerFromTeam_Click(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbPlayerInTeam.SelectedItem;
            selectedTeam = (Team)lbTeamChart.SelectedItem;

            DialogResult dropPlayerFromTeam = MessageBox.Show("Vill du verkligen ta bort den markerade spelaren från laget?", "Ta bort spelare", MessageBoxButtons.OKCancel);
            if (dropPlayerFromTeam == DialogResult.OK)
            {

                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    string sql = "UPDATE player SET team_id = null WHERE team_id = " + selectedTeam.teamId + " AND golfid = " + selectedPlayer.golfId + "";
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                    int antal = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                lbPlayerInTeam.DataSource = Methods.GetPlayerInTeam(selectedTeam.teamId);
                lbPlayers.DataSource = Methods.GetAvailablePlayers();
                MessageBox.Show("Spelaren är nu borttagen från laget.");
            }
            else if (dropPlayerFromTeam == DialogResult.Cancel)
            { }
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            DialogResult dropTeam = MessageBox.Show("Vill du verkligen ta bort det markerade laget?", "Ta bort lag", MessageBoxButtons.OKCancel);
            if (dropTeam == DialogResult.OK)
            {
                selectedTeam = (Team)lbTeamChart.SelectedItem;
                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    string sql = "DELETE FROM team WHERE id = " + selectedTeam.teamId + "";
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                    int antal = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                
                lbTeamChart.DataSource = Methods.GetTeams();
                lbPlayers.DataSource = Methods.GetAvailablePlayers();
            }
            else if (dropTeam == DialogResult.Cancel)
            { }
        }

        private void btnCreateCouple_Click(object sender, EventArgs e)
        {
            if ((txtCoupleName.Text.Trim().Length == 0)) //kod som undersöker om det finns någon text i textbox
            { MessageBox.Show("Du måste välja ett namn på paret!"); }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO couple (name) VALUES ('" + txtCoupleName.Text + "')", conn);
                    int antal = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                lbCoupleChart.DataSource = Methods.GetCouples();
            }

        }

        private void btnDeletePlayerFromCouple_Click(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbPlayerInCouple.SelectedItem;
            selectedCouple = (Couple)lbCoupleChart.SelectedItem;
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            try
            {
                string sql = "UPDATE player SET couple_id = null WHERE couple_id = " + selectedCouple.coupleId + " AND golfid = " + selectedPlayer.golfId + "";
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                int antal = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            lbPlayerInCouple.DataSource = Methods.GetPlayerInCouple(selectedCouple.coupleId);
            lbPlayers2.DataSource = Methods.GetAvailablePlayersToCouple();
        }

        private void btnDeleteCouple_Click(object sender, EventArgs e)
        {
            DialogResult dropCouple = MessageBox.Show("Vill du verkligen ta bort det markerade paret?", "Ta bort Par", MessageBoxButtons.OKCancel);
            if (dropCouple == DialogResult.OK)
            {
                selectedCouple = (Couple)lbCoupleChart.SelectedItem;
                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    string sql = "DELETE FROM couple WHERE id = " + selectedCouple.coupleId + "";
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                    int antal = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                lbCoupleChart.DataSource = Methods.GetCouples();
                lbPlayers2.DataSource = Methods.GetAvailablePlayersToCouple();
            }
            else if (dropCouple == DialogResult.Cancel)
            { }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Show();
            groupBox3.Hide();
            groupBox4.Hide();
            lbCompetitionChart.DataSource = Methods.GetTeamCompetitions();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Show();
            groupBox4.Hide();
            lbCompetitionChart.DataSource = Methods.GetCoupleCompetitions();
        }

        private void btnAddPlayerToCouple_Click(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbPlayers2.SelectedItem;
            selectedCouple = (Couple)lbCoupleChart.SelectedItem;

            for (int x = 0; x < lbPlayerInCouple.Items.Count; x++) //ser till så att inte fler än 4 kan vara med i samma grupp
            {
                lbPlayerInCouple.SetSelected(x, true);
            }
            if (lbPlayerInCouple.Items.Count >= 2)
            {
                MessageBox.Show("Du kan inte lägga till fler spelare");
            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand("UPDATE player SET couple_id = " + selectedCouple.coupleId + " WHERE golfid = (" + selectedPlayer.golfId + " )", conn);
                    int antal = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                lbPlayerInCouple.DataSource = Methods.GetPlayerInCouple(selectedCouple.coupleId);
                lbPlayers2.DataSource = Methods.GetAvailablePlayersToCouple();
                lbPlayers.DataSource = Methods.GetAvailablePlayers();
            }
        }

        private void lbCompetitionChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPlayerHasGolfround.Items.Clear();
            selectedCompetition = (Competition)lbCompetitionChart.SelectedItem;
            lbPlayersInCompetition.DataSource = Methods.GetPlayersInCompetition(selectedCompetition.Id);

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true;");
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM player JOIN golfround ON player.golfid = golfround.player JOIN competition ON golfround.date = competition.startdate WHERE competition.startdate = '" + selectedCompetition.startDate + "'", conn);
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                //    MessageBox.Show((dr["firstname"] + " " + dr["lastname"]));
                    lbPlayerHasGolfround.Items.Add(dr["firstname"] + " " + dr["lastname"]);
                }
            }
            finally
            {

                conn.Close();
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Show();
            lbCompetitionChart.DataSource = Methods.GetSingleCompetitions();
        }

        private void txtStartDate_Click(object sender, EventArgs e)
        {
            txtStartDate.Clear();
            txtStartDate.ForeColor = Color.Black;
        }

        private void txtEndDate_Click(object sender, EventArgs e)
        {
            txtEndDate.Clear();
            txtEndDate.ForeColor = Color.Black;
        }

        private void txtLastBookingDate_Click(object sender, EventArgs e)
        {
            txtLastBookingDate.Clear();
            txtLastBookingDate.ForeColor = Color.Black;
        }

        private void txtLastUnbookingDate_Click(object sender, EventArgs e)
        {
            txtLastUnbookingDate.Clear();
            txtLastUnbookingDate.ForeColor = Color.Black;
        }

        private void lbSinglePlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCoupleChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCouple = (Couple)lbCoupleChart.SelectedItem;
            lbPlayerInCouple.DataSource = Methods.GetPlayerInCouple(selectedCouple.coupleId);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedCompetition = (Competition)lbCompetitionChart.SelectedItem;
            selectedPlayer = (Player)lbSinglePlayers.SelectedItem;

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO player_competition (competition_id, player_id) VALUES (" + selectedCompetition.Id + "," + selectedPlayer.golfId + ")", conn);
                int antal = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            lbPlayersInCompetition.DataSource = Methods.GetPlayersInCompetition(selectedCompetition.Id);
        }

        private void btnDropPlayerFromComp_Click(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbPlayersInCompetition.SelectedItem;
            selectedCompetition = (Competition)lbCompetitionChart.SelectedItem;

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            try
            {
                string sql = "DELETE FROM player_competition WHERE competition_id = " + selectedCompetition.Id + " AND player_id = " + selectedPlayer.golfId + "";
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                int antal = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Du har nu avbokat spelaren från tävlingen.");
                lbPlayersInCompetition.DataSource = Methods.GetPlayersInCompetition(selectedCompetition.Id);
                conn.Close();
            }
        }

       

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtAddResult.Text);
            selectedPlayer = (Player)lbGolfPlayers.SelectedItem;
            selectedCompetition = (Competition)lbPassedCompetitionChart.SelectedItem;

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            try
            {
                string sql = "UPDATE player_competition SET result = " + result + " WHERE player_id = " + selectedPlayer.golfId + " AND competition_id = " + selectedCompetition.Id + "";
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                int antal = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                txtAddResult.Clear();
            }
        }
 

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            if (rbClassA.Checked == true)
            {
                lbResults.Items.Clear();
                selectedCompetition = (Competition)lbPassedCompetitionChart.SelectedItem;
                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand("SELECT *, result FROM player JOIN player_competition ON player.golfid = player_competition.player_id AND player_competition.competition_id = " + selectedCompetition.Id + " ORDER BY result", conn);
                    NpgsqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {

                        if (0 <= Convert.ToInt32(dr["handicap"]) && selectedCompetition.classA >= Convert.ToInt32(dr["handicap"]))
                        {
                            lbResults.Items.Add(dr["firstname"] + " " + dr["lastname"] + " " + dr["result"]);
                        }
                        else
                        {
                        }
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
                if (rbClassB.Checked == true)
            {
                lbResults.Items.Clear();
                selectedCompetition = (Competition)lbPassedCompetitionChart.SelectedItem;
                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand("SELECT firstname, lastname, handicap, result FROM player JOIN player_competition ON player.golfid = player_competition.player_id AND player_competition.competition_id = " + selectedCompetition.Id + " ORDER BY result", conn);
                    NpgsqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {

                        if (Convert.ToInt32(dr["handicap"]) > selectedCompetition.classA && Convert.ToInt32(dr["handicap"]) <= selectedCompetition.classB)
                        {
                            lbResults.Items.Add(dr["firstname"] + " " + dr["lastname"] + " " + dr["result"]);
                        }
                        else
                        {
                        }
                    }
                }
                finally
                {
                    conn.Close();
                }
                }

                if (rbClassC.Checked == true)
                {
                    lbResults.Items.Clear();
                    selectedCompetition = (Competition)lbPassedCompetitionChart.SelectedItem;
                    NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                    try
                    {
                        conn.Open();
                        NpgsqlCommand command = new NpgsqlCommand("SELECT firstname, lastname, handicap, result FROM player JOIN player_competition ON player.golfid = player_competition.player_id AND player_competition.competition_id = " + selectedCompetition.Id + " ORDER BY result", conn);
                        NpgsqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {

                            if (Convert.ToInt32(dr["handicap"]) > selectedCompetition.classB)
                            {
                                lbResults.Items.Add(dr["firstname"] + " " + dr["lastname"] + " " + dr["result"]);
                            }
                            else
                            {
                            }
                        }
                    }
                    finally
                    {
                        conn.Close();
                    }

            }
        }

        private void lbPassedCompetitionChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbResults.Items.Clear();
            selectedCompetition = (Competition)lbPassedCompetitionChart.SelectedItem;
            lbGolfPlayers.DataSource = Methods.GetPlayersInPassedCompetition(selectedCompetition.Id);
        }

        private void DropAllPlayers()
        {
            DialogResult dropAllPlayers = MessageBox.Show("Vänligen bekräfta om du önskar att avboka spelaranas golftid och skicka ett meddelande om detta till dem.", "Vill du avboka spelarna?", MessageBoxButtons.OKCancel);
            if (dropAllPlayers == DialogResult.OK)
            {
                selectedCompetition = (Competition)lbCompetitionChart.SelectedItem;
                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    string sql = "UPDATE golfround SET player = null WHERE date = '" + selectedCompetition.startDate + "'";
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                    int antal = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Det finns inga spelare att avboka");
                }
                finally
                {
                    conn.Close();
                }

            }
            else if (dropAllPlayers == DialogResult.Cancel)
            { }

        }

        private void btnDropPlayersDuringComp_Click(object sender, EventArgs e)
        {
            DropAllPlayers();
            lbPlayerHasGolfround.Items.Clear();
        }
        
       
           
    }
}
