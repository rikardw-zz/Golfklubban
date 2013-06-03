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
        Competition selectedCompetition = new Competition();

        public CompetitionChart()
        {
            InitializeComponent();
            
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
    }
}
