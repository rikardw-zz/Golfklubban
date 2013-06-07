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
    public partial class CoupleChart : Form
    {
        public CoupleChart()
        {
            InitializeComponent();
        }

        private Player selectedPlayer;
        private Couple selectedCouple;

        private void btnCreateCouple_Click(object sender, EventArgs e)
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

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbPlayer.SelectedItem;
            selectedCouple = (Couple)lbCoupleChart.SelectedItem;

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand("UPDATE player SET team_id = " + selectedCouple.coupleId + " WHERE golfid = (" + selectedPlayer.golfId + " )", conn);
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
}
