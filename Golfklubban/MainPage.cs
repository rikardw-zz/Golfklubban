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
            DateTime chosenDate = getCompetitionDate();
            DateTime pickedDate = monthCalendar1.SelectionStart;            
            if (pickedDate == chosenDate)
            {
                MessageBox.Show("En tävling finns bokad på valt datum. Det går inte att boka en golfrunda på detta datum");
            }



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
                    //     DateTime pickedDate = monthCalendar1.SelectionStart;
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
                    //  lbBookedPlayers.ClearSelected();
                    lbBookedPlayers.DataSource = Methods.GetBookedPlayers(pickedDate, pickedTime);                
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

        private DateTime getCompetitionDate()
        {
            DateTime pickedDate = monthCalendar1.SelectionStart;            
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            NpgsqlCommand command = new NpgsqlCommand("SELECT starttime FROM competition WHERE starttime = '" + pickedDate + "'", conn);
            conn.Open();
            object startDate = command.ExecuteScalar();
            string stringShosenDate = Convert.ToString(startDate);
            DateTime chosenDate;
            MessageBox.Show("" + startDate);
            if (string.IsNullOrEmpty(stringShosenDate) == true)
            {
                //här läggs spelare till på den tid som valts                           
            }
            else 
            {
                MessageBox.Show("Detta datum är tyvärr bokat för en tävling");
            }


         /*   string stringValue = Convert.ToString(command.ExecuteScalar());
            double handicapValue = 0;
            if (string.IsNullOrEmpty(stringValue) == true)
            {
                handicapValue = 0;
            }
            else
            {
                handicapValue = handicapValue + Convert.ToDouble(stringValue);
            }
            */
            return chosenDate;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

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
        
        } 
    }

