using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;
//Rikardärbäst

namespace Golfklubban
{
    public partial class CompetitionChart : Form
    {
        Team selectedTeam = new Team();
        Player selectedPlayer = new Player();
        Competition selectedCompetition = new Competition();

        public CompetitionChart()
        {
            InitializeComponent();
            lbPlayers.DataSource = Methods.GetAvailablePlayers();
            lbTeamChart.DataSource = Methods.GetTeams();
            
        }
        private void btnRegisterCompetition_Click(object sender, EventArgs e)
        {
            addCompetition();            
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

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true;");
            try
            {
                conn.Open();
                string insert = "INSERT INTO competition (name, startdate, enddate, lastbookingdate, lastunbookingdate, classa, classb, classc) VALUES('" + name + "','" + startDate + "','" + endDate + "','" + lastBooking + "','" + lastUnbooking + "'," + classA + "," + classB + "," + classC + ")";
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
                lbCompetitionChart.DataSource = Methods.GetCompetitions();
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
                lbCompetitionChart.DataSource = Methods.GetCompetitions();
                conn.Close();
            }
        }

        private void CompetitionChart_Load(object sender, EventArgs e)
        {
            lbCompetitionChart.DataSource = Methods.GetCompetitions();            
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
            }
        }
        private void lbTeamChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.Text = Convert.ToString(lbTeamChart.SelectedItem.ToString()) + "";
            selectedTeam = (Team)lbTeamChart.SelectedItem;
            lbPlayerInTeam.DataSource = Methods.GetPlayerInTeam(selectedTeam.teamId);
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbPlayers.SelectedItem;
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
        }

        private void btnDeletePlayerFromTeam_Click(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbPlayerInTeam.SelectedItem;
            selectedTeam = (Team)lbTeamChart.SelectedItem;
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            try
            {
                string sql = "UPDATE player SET team_id = null WHERE team_id = " + selectedTeam.teamId + " AND golfid = " + selectedPlayer.golfId + "";
                //UPDATE player SET team_id = " + selectedTeam.teamId + " WHERE golfid = (" + selectedPlayer.golfId + " )
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
        }

        
    }
}
