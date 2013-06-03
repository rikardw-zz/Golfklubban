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
    public partial class TeamChart : Form
    {
        public TeamChart()
        {
            InitializeComponent();
        }
        private Player selectedPlayer;
        private Team selectedTeam;

        private void btnCreateTeam_Click(object sender, EventArgs e)
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

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbPlayer.SelectedItem;
            selectedTeam = (Team)lbTeamChart.SelectedItem;

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand("UPDATE player SET team_id = "+ selectedTeam.teamId +" WHERE golfid = (" +selectedPlayer.golfId + " )", conn);
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

        private void TeamChart_Load(object sender, EventArgs e)
        {
            lbPlayer.DataSource = Methods.GetPlayers();
            lbTeamChart.DataSource = Methods.GetTeams();
        }

        private void lbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbPlayer.SelectedItem;
        }

        private void lbTeamChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeam = (Team)lbTeamChart.SelectedItem;
            lbPlayerInTeam.DataSource = Methods.GetPlayerInTeam(selectedTeam.teamId);
        }

        private void btnDeletePlayerFromTeam_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {

        }
        }
    }

