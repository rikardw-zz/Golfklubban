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
    public partial class MainPage : Form
    {        
        Player selectedPlayer = new Player();

        public MainPage()
        {            
            InitializeComponent();
            lbMainPagePlayers.DataSource = Methods.GetPlayers();
            lbTimes.DataSource = Methods.GetTimeIntervals();
            lbTimes.ClearSelected();
            lbMainPagePlayers.ClearSelected();

        }
        private void stängToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void visaMedlemmarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerChart openPlayerChart = new PlayerChart();
            openPlayerChart.Show();
        }
        private void läggTillMedlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerChart openPlayerChart = new PlayerChart();
            openPlayerChart.Show();
        }
        private void visaLagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamChart openTeamChart = new TeamChart();
            openTeamChart.Show();
        }
        private void visaKommandeTävlingarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompetitionChart openPlayerChart = new CompetitionChart();
            openPlayerChart.Show();
        }
        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Golfklubban V0.1");
        }
        private void bokaInförTävlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompetitionChart openCompetitionChart = new CompetitionChart();
            openCompetitionChart.Show();
        }

        private void tsmCoupleView_Click(object sender, EventArgs e)
        {
            CoupleChart openCoupleChart = new CoupleChart();
            openCoupleChart.Show();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            int playerGolfID = Convert.ToInt32(txtSearchGolfId.Text);
            lbMainPagePlayers.DataSource = Methods.SearchPlayer(playerGolfID);
        }

        private void txtBooking_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < lbBookedPlayers.Items.Count; x++) //ser till så att inte fler än 4 kan vara med i samma grupp
            {
                lbBookedPlayers.SetSelected(x, true);
            }
            if (lbBookedPlayers.Items.Count >= 4)
            {
                MessageBox.Show("Du kan inte lägga till fler spelare");
            }
            else
            {
                selectedPlayer = (Player)lbMainPagePlayers.SelectedItem;
                DateTime pickedDate = monthCalendar1.SelectionStart;

                string pickedTime = lbTimes.SelectedItem.ToString();

                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO golfround (date, startingtime, player) VALUES ('" + pickedDate + "' , '" + pickedTime + "', '" + selectedPlayer.golfId + "')", conn);
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
                lbBookedPlayers.ClearSelected();
                lbBookedPlayers.DataSource = Methods.GetBookedPlayers(pickedDate, pickedTime);
            }
        }

        private void txtGetPlayers_Click(object sender, EventArgs e)
        {
            lbBookedPlayers.Items.Clear();
            GetPlayerTimes();
        }

        private void GetPlayerTimes()
        {
            DateTime pickedDate = monthCalendar1.SelectionStart;
            string pickedTime = Convert.ToString(lbTimes.SelectedItem);

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT firstname, lastname FROM player INNER JOIN golfround ON player.golfid = golfround.playerone where date ='" + pickedDate + "' AND startingtime = '" + pickedTime + "'", conn);
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    lbBookedPlayers.Items.Add(dr["firstname"] + " " + dr["lastname"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();

            }

        }

        private void txtDropPlayer_Click(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbBookedPlayers.SelectedItem;
            DateTime pickedDate = monthCalendar1.SelectionStart;
            string pickedTime = lbTimes.SelectedItem.ToString();

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            try
            {
                string sql = "UPDATE golfround SET player = null WHERE date = '" + pickedDate + "' AND startingtime = '" + pickedTime + "' AND player = " + selectedPlayer.golfId + "";
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

            lbBookedPlayers.DataSource = Methods.GetBookedPlayers(pickedDate, pickedTime);
        }

        private void lbTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime pickedDate = monthCalendar1.SelectionStart;
            string pickedTime = Convert.ToString(lbTimes.SelectedItem);
            lbBookedPlayers.DataSource = Methods.GetBookedPlayers(pickedDate, pickedTime);
        }
    }
}
