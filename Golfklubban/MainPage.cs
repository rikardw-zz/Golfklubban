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
        Maintenance selectedMaintenance = new Maintenance();

        public MainPage()
        {            
            InitializeComponent();
            lbMainPagePlayers.DataSource = Methods.GetPlayers();
            lbTimes.DataSource = Methods.GetTimeIntervals();            
            label2.Text = ("Spelare bokade klockan " +lbTimes.Text );
            lbUpcomingMaintenance.DataSource = Methods.GetUpcomingMaintenance();
         //   lbTimes.ClearSelected();
        //    lbMainPagePlayers.ClearSelected();

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
            if ((txtSearchGolfId.Text.Trim().Length == 0 && txtSearchLastName.Text.Trim().Length == 0))
            { MessageBox.Show("Du måste fylla i antingen Golf-ID eller efternamn innan du gör en sökning"); }

            if ((txtSearchGolfId.Text.Trim().Length == 0))
            { }
            else
            {
                int playerGolfID = Convert.ToInt32(txtSearchGolfId.Text);
                lbMainPagePlayers.DataSource = Methods.SearchPlayer(playerGolfID);
                txtSearchGolfId.Clear();
            }
            if ((txtSearchLastName.Text.Trim().Length == 0))
            { }
            else
            {
                string playerLastName = txtSearchLastName.Text;
                lbMainPagePlayers.DataSource = Methods.SearchPlayerByLastName(playerLastName);
                txtSearchLastName.Clear();
            }

            for (int x = 0; x < lbMainPagePlayers.Items.Count; x++) //ser till så att inte fler än 4 kan vara med i samma grupp
            {
                lbMainPagePlayers.SetSelected(x, true);
            }
            if (lbBookedPlayers.Items.Count < 1)
            {
                MessageBox.Show("Ingen spelare hittas på angivet sökkriterie");
                lbMainPagePlayers.DataSource = Methods.GetPlayers();
            }
        }

        private void txtBooking_Click(object sender, EventArgs e)
        {
            DateTime pickedDate = monthCalendar1.SelectionStart; //vald i kalender
            string convPickedDate = pickedDate.ToShortDateString(); //konvert till endast datum
            string chosenDate = getCompetitionDate(); //hämtar tävlingsdatum
            string pickedTime = lbTimes.SelectedItem.ToString(); //hämtar klockslag

            string maintenanceStartTime = getMaintenanceStartTime(); //hämtar starttid för banunderhåll
            string maintenanceEndTime = getMaintenanceEndTime();
            DateTime startDateAndTime = Convert.ToDateTime(convPickedDate + " " + maintenanceStartTime); //datum och starttid för banunderhåll
            DateTime endDateAndTime = Convert.ToDateTime(convPickedDate + " " + maintenanceEndTime); //datum och sluttid för banunderhåll

            DateTime playerPickedDateAndTime = Convert.ToDateTime(convPickedDate + " " + pickedTime); //Datum och tid som spelare vill boka in golfrunda på

            if (playerPickedDateAndTime > startDateAndTime && playerPickedDateAndTime < endDateAndTime)
            {
                MessageBox.Show("Ett underhåll av banan kommer att ske på vald tid och det går inte att boka en golfrunda förrän klockan" + " " + maintenanceEndTime);
                return;
            }
            else
            { }
            if (convPickedDate == chosenDate)
            {
                MessageBox.Show("En tävling finns bokad på valt datum. Det går inte att boka en golfrunda på detta datum");
                return;
            }
            else
            { }



            for (int x = 0; x < lbBookedPlayers.Items.Count; x++) //ser till så att inte fler än 4 kan vara med i samma grupp
            {
                lbBookedPlayers.SetSelected(x, true);
            }
            if (lbBookedPlayers.Items.Count >= 4)
            {
                MessageBox.Show("Du kan inte lägga till fler spelare");
            }           
                selectedPlayer = (Player)lbMainPagePlayers.SelectedItem;
                double teamTotalHp = getTotalHandicap();
                double playerHp = selectedPlayer.handicap;

                if (teamTotalHp + playerHp > 100)
                {
                    MessageBox.Show("Om du lägger till denna spelare kommer det totala handikapsvärdet överstiga 100.\nDu kan ej lägga till fler spelare");
                }
                else
                {
                   

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
                    //  lbBookedPlayers.ClearSelected();
                    lbBookedPlayers.DataSource = Methods.GetBookedPlayers(pickedDate, pickedTime);
                    lbMainPagePlayers.DataSource = Methods.GetUnbookedPlayers(pickedDate, pickedTime);
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
            lbMainPagePlayers.DataSource = Methods.GetUnbookedPlayers(pickedDate, pickedTime);
        }

        private void lbTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime pickedDate = monthCalendar1.SelectionStart;
            string pickedTime = Convert.ToString(lbTimes.SelectedItem);
            lbBookedPlayers.DataSource = Methods.GetBookedPlayers(pickedDate, pickedTime);
            lbMainPagePlayers.DataSource = Methods.GetUnbookedPlayers(pickedDate, pickedTime);
            label2.Text = ("Spelare bokade kl " + lbTimes.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }  
        private double getTotalHandicap() 
        {            

            DateTime pickedDate = monthCalendar1.SelectionStart;
            string stringPickedDate = pickedDate.ToShortDateString();
            string pickedTime = lbTimes.SelectedItem.ToString();            
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            NpgsqlCommand command = new NpgsqlCommand("SELECT SUM(handicap) FROM player INNER JOIN golfround ON player.golfid = golfround.player WHERE date = '" + stringPickedDate + "' AND startingtime ='" + pickedTime + "'", conn);
            conn.Open();            
           // object objValue = command.ExecuteScalar();
            string stringValue = Convert.ToString(command.ExecuteScalar());           
            double handicapValue = 0;
            if (string.IsNullOrEmpty(stringValue) == true)
            {
                handicapValue = 0;                
            }
            else 
            {
                handicapValue = handicapValue + Convert.ToDouble(stringValue);                             
            }
            
          //  handicapValue = handicapValue + Convert.ToDouble(objValue);
              //  handicapValue = Convert.ToDouble(objValue);                
            return handicapValue;
        }

        private void btnRegisterGuest_Click(object sender, EventArgs e)
        {
            int guestId = Convert.ToInt32(txtGuestGolfId.Text);
            string guestFirstName = txtGuestFirstName.Text;
            string guestLastName = txtGuestLastName.Text;
            string guestTelephone = txtGuestMobilePhone.Text;
            double guestHandicap = Convert.ToDouble(txtGuestHandicap.Text);
            int guestStatus = 5;
            bool guestMembershipFee = false;

            string playerSex = cbGuestSex.GetItemText(cbGuestSex.SelectedItem);

            bool guestSex = selectedPlayer.sex;
            if (playerSex.Equals("Man"))
            { guestSex = true; }
            else
            {
                guestSex = false;
            }
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true;");
            try
            {
                conn.Open();
                string insert = "INSERT INTO player (golfid, playerstatus_id, firstname, lastname, mobile, handicap, sex, membershipfee) VALUES('" + guestId + "', '"+ guestStatus + "','" + guestFirstName + "','" + guestLastName + "','" + guestTelephone + "','" + guestHandicap + "', '"+ guestSex + "','" + guestMembershipFee + "')";
                NpgsqlCommand command = new NpgsqlCommand(insert, conn);
                //används när man kör INSERT fråga
                int numberOfAffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Du måste fylla i alla fält innan du kan registrera personen");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                lbMainPagePlayers.DataSource = Methods.GetPlayers();
                conn.Close();
            }
            txtGuestFirstName.Clear();
            txtGuestLastName.Clear();
            txtGuestGolfId.Clear();
            txtGuestHandicap.Clear();
            txtGuestMobilePhone.Clear();
        }

        private string getCompetitionDate()
        {
            DateTime pickedDate = monthCalendar1.SelectionStart;
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            NpgsqlCommand command = new NpgsqlCommand("SELECT startdate FROM competition WHERE startdate = '" + pickedDate + "'", conn);
            conn.Open();
            Object startDate = command.ExecuteScalar();
            DateTime conStartDate = Convert.ToDateTime(startDate);
            string convStartDate = conStartDate.ToShortDateString();
            string stringChosenDate = "2013-06-01";

        //    MessageBox.Show("" + startDate);
            if (string.IsNullOrEmpty(convStartDate) == true)
            {
                stringChosenDate = "2013-06-01";
            }
            else
            {
                stringChosenDate = convStartDate;
            }

            return stringChosenDate; 
        }
        private void tsmCompetitionAddPlayer_Click(object sender, EventArgs e)
        {
            CompetitionChart cc = new CompetitionChart();
            cc.Show();
        }

        private void tsmPlayerChange_Click(object sender, EventArgs e)
        {
            PlayerChart pc = new PlayerChart();
            pc.Show();
        }

        private void stängToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGuestGolfId_Click(object sender, EventArgs e)
        {
            txtGuestGolfId.Clear();
            txtGuestGolfId.ForeColor = Color.Black;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtMaintenanceDate.Clear();
            txtMaintenanceDate.ForeColor = Color.Black;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtMaintenanceStart.Clear();
            txtMaintenanceStart.ForeColor = Color.Black;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            txtMaintenanceEnd.Clear();
            txtMaintenanceEnd.ForeColor = Color.Black;
        }
        private string getMaintenanceStartTime() //hämtar starttid för underhåll
        {
            string pickedDate = monthCalendar1.SelectionStart.ToString();

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            NpgsqlCommand command = new NpgsqlCommand("SELECT startingtime FROM golfround WHERE date = '" + pickedDate + "' AND staff_id is not null", conn);
            conn.Open();
            Object startTime = command.ExecuteScalar();
            string conStartTime = Convert.ToString(startTime);
            //     DateTime conStartDate = Convert.ToDateTime(startTime);
            //     string convStartDate = conStartDate.ToShortDateString();
            string maintenanceStartTime = "19:00:00";


            if (string.IsNullOrEmpty(conStartTime) == true)
            {
                maintenanceStartTime = "19:00:00";
            }
            else
            {
                maintenanceStartTime = conStartTime;
            }

            return maintenanceStartTime;
        }
        private string getMaintenanceEndTime() //hämtar sluttid för underhåll
        {
            string pickedDate = monthCalendar1.SelectionStart.ToString();

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            NpgsqlCommand command = new NpgsqlCommand("SELECT endtime FROM golfround WHERE date = '" + pickedDate + "' AND staff_id is not null", conn);
            conn.Open();
            Object endTime = command.ExecuteScalar();
            string conEndDate = Convert.ToString(endTime);

            string maintenanceEndTime = "07:00:00";


            if (string.IsNullOrEmpty(conEndDate) == true)
            {
                maintenanceEndTime = "07:00:00";
            }
            else
            {
                maintenanceEndTime = conEndDate;
            }

            return maintenanceEndTime;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            string maintenanceDate = txtMaintenanceDate.Text;
            string chosenDate = getCompetitions();
            if (maintenanceDate == chosenDate)
            {
                MessageBox.Show("Det går inte att boka banan för underhåll på valt datum då en tävling ska spelas då.");
                return;
            }
            else
            {
                BookMaintenance();
            }
        }

        private void BookMaintenance()
        {

            DateTime maintenanceDate = Convert.ToDateTime(txtMaintenanceDate.Text);
            string maintenanceStart = txtMaintenanceStart.Text;
            string maintenanceEnd = txtMaintenanceEnd.Text;
            int staffId = Convert.ToInt16(txtStaffId.Text);

            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true;");
            try
            {
                conn.Open();
                string insert = "INSERT INTO golfround (date, startingtime, endtime, staff_id) VALUES('" + maintenanceDate + "','" + maintenanceStart + "','" + maintenanceEnd + "','" + staffId + "')";
                NpgsqlCommand command = new NpgsqlCommand(insert, conn);
                int numberOfAffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                conn.Close();
            }
            MessageBox.Show("Du har nu bokat hela banan");
            txtMaintenanceDate.Clear();
            txtMaintenanceStart.Clear();
            txtMaintenanceEnd.Clear();
            txtStaffId.Clear();
        }
        private string getCompetitions()
        {
            string pickedDate = txtMaintenanceDate.Text;
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            NpgsqlCommand command = new NpgsqlCommand("SELECT startdate FROM competition WHERE startdate = '" + pickedDate + "'", conn);
            conn.Open();
            Object startDate = command.ExecuteScalar();
            DateTime conStartDate = Convert.ToDateTime(startDate);
            string convStartDate = conStartDate.ToShortDateString();
            string stringChosenDate = "2013-06-01";

            //    MessageBox.Show("" + startDate);
            if (string.IsNullOrEmpty(convStartDate) == true)
            {
                stringChosenDate = "2013-06-01";
            }
            else
            {
                stringChosenDate = convStartDate;
            }

            return stringChosenDate;
        }

        private void btnCancelMaintenance_Click(object sender, EventArgs e)
        {
            DialogResult dropMaintenance = MessageBox.Show("Vill du verkligen avboka den aktuella banskötseln?", "Avboka banskötsel", MessageBoxButtons.OKCancel);
            if (dropMaintenance == DialogResult.OK)
            {
                selectedMaintenance = (Maintenance)lbUpcomingMaintenance.SelectedItem;
                NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    string sql = "DELETE FROM golfround WHERE id = " + selectedMaintenance.maintenanceId + "";
                    conn.Open();
                    NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                    int antal = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Det finns inget underhåll att avboka.");
                }
                finally
                {
                    conn.Close();
                }
                lbUpcomingMaintenance.DataSource = Methods.GetUpcomingMaintenance();
            }

            else if (dropMaintenance == DialogResult.Cancel)
            { }
        }
        }
    }     
}

