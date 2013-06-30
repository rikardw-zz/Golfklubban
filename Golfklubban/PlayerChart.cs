using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace Golfklubban
{
    public partial class PlayerChart : Form
    {
        public const string conString = "MIUN";
        private Player selectedPlayer;
        public PlayerChart()
        {
            InitializeComponent();
        }
        private void PlayerChart_Load(object sender, EventArgs e)
        {
            lbPlayerChart.DataSource = Methods.GetPlayers();
            lbPlayerChart.ClearSelected();
        }        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status = cbMembershipStatus.GetItemText(cbMembershipStatus.SelectedItem);
            int playerStatus = selectedPlayer.membershipStatus;
            if (status.Equals("Aktiv"))
            { playerStatus = 1; }
            else if (status.Equals("Vilande"))
            { playerStatus = 2; }
            else if (status.Equals("Junior"))
            { playerStatus = 3; }
            else if (status.Equals("Greenfee"))
            { playerStatus = 4; }
            else if (status.Equals("Gäst"))
            { playerStatus = 5; }

            //liknande kod för att registrera om spelaren betalt avgift
            string fee = cbMembershipFee.GetItemText(cbMembershipFee.SelectedItem);
            bool membershipFee = selectedPlayer.membershipFee;
            if (fee.Equals("Betald"))
            { membershipFee = true; }
            else
            {
                membershipFee = false;
            }
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
            command.Parameters[0].Value = txtFirstName.Text;
            command.Parameters.Add(new NpgsqlParameter("lastName", DbType.String));
            command.Parameters[1].Value = txtLastName.Text;
            command.Parameters.Add(new NpgsqlParameter("address", DbType.String));
            command.Parameters[2].Value = txtAddress.Text;
            command.Parameters.Add(new NpgsqlParameter("streetNumber", DbType.String));
            command.Parameters[3].Value = txtStreetNumber.Text;
            command.Parameters.Add(new NpgsqlParameter("zipCode", DbType.Int32));
            command.Parameters[4].Value = Convert.ToInt32(txtZipCode.Text);
            command.Parameters.Add(new NpgsqlParameter("mobilePhone", DbType.String));
            command.Parameters[5].Value = txtMobile.Text;
            command.Parameters.Add(new NpgsqlParameter("eMail", DbType.String));
            command.Parameters[6].Value = txtEmail.Text;
            command.Parameters.Add(new NpgsqlParameter("handicap", DbType.Double));
            command.Parameters[7].Value = Convert.ToDouble(txtHandicap.Text);
            command.Parameters.Add(new NpgsqlParameter("golfId", DbType.Int32));
            command.Parameters[8].Value = Convert.ToInt32(txtGolfId.Text); //Ska GolfID gå att ändra?
            command.Parameters.Add(new NpgsqlParameter("membershipStatus", DbType.Int32));
            command.Parameters[9].Value = playerStatus;
            command.Parameters.Add(new NpgsqlParameter("membershipFee", DbType.Boolean));
            command.Parameters[10].Value = membershipFee;

            int numberOfRowsAffected = command.ExecuteNonQuery();
            lbPlayerChart.DataSource = Methods.GetPlayers();
            conn.Close();
        }

        private void lbPlayerChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbPlayerChart.SelectedItem;
            if (selectedPlayer == null)
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtGolfId.Clear();
                txtMobile.Clear();
                txtStreetNumber.Clear();
                txtZipCode.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtHandicap.Clear();
            }
            else
            {
                txtFirstName.Text = selectedPlayer.firstName;
                txtLastName.Text = selectedPlayer.lastName;
                txtGolfId.Text = selectedPlayer.golfId.ToString();
                txtMobile.Text = selectedPlayer.mobilePhone;
                txtStreetNumber.Text = selectedPlayer.streetNumber;
                txtZipCode.Text = selectedPlayer.zipCode.ToString();
                txtEmail.Text = selectedPlayer.eMail;
                txtAddress.Text = selectedPlayer.address;
                txtHandicap.Text = selectedPlayer.handicap.ToString();
                //Kön
                if (Convert.ToString(selectedPlayer.sex) == "True")
                {
                    cbSex.Text = "Man";
                }
                else
                {
                    cbSex.Text = "Kvinna";
                }
                //Medlemasavgift
                if (Convert.ToString(selectedPlayer.membershipFee) == "True")
                {
                    cbMembershipFee.Text = "Betald";
                }
                else
                {
                    cbMembershipFee.Text = "Ej betald";
                }
                //Medlemstatus           
                if (Convert.ToString(selectedPlayer.membershipStatus) == "1")
                {
                    cbMembershipStatus.Text = "Aktiv";
                }
                else if (Convert.ToString(selectedPlayer.membershipStatus) == "2")
                {
                    cbMembershipStatus.Text = "Vilande";
                }
                else if (Convert.ToString(selectedPlayer.membershipStatus) == "3")
                {
                    cbMembershipStatus.Text = "Junior";
                }
                else if (Convert.ToString(selectedPlayer.membershipStatus) == "4")
                {
                    cbMembershipStatus.Text = "Greenfee";
                }
                else if (Convert.ToString(selectedPlayer.membershipStatus) == "5")
                {
                    cbMembershipStatus.Text = "Gäst";
                }
            }
        }
        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
          DialogResult dr = MessageBox.Show(("Är du säker på att du vill ta bort spelare " + selectedPlayer.firstName + " " + selectedPlayer.lastName + "?"), "Ta bort medlem?", MessageBoxButtons.YesNo);
          if (dr == DialogResult.Yes)
          {
              selectedPlayer = (Player)lbPlayerChart.SelectedItem;
              NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
              try
              {
                  string sql = "DELETE FROM player WHERE golfid = '" + selectedPlayer.golfId + "'";
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
              lbPlayerChart.DataSource = Methods.GetPlayers();
          }
          else if (dr == DialogResult.No)
          {
          }  
        }           
        private void btnRegister_Click(object sender, EventArgs e)
        {            
            string chosenStatus = cbMembershipStatus.GetItemText(cbMembershipStatus.SelectedItem); //hämtar info av valt item i comboboxen
            int playerStatus = 1;
            if (chosenStatus.Equals("Aktiv"))
            { playerStatus = 1; }
            else if (chosenStatus.Equals("Vilande"))
            { playerStatus = 2; }
            else if (chosenStatus.Equals("Junior"))
            { playerStatus = 3; }
            else if (chosenStatus.Equals("Greenfee"))
            { playerStatus = 4; }
            else if (chosenStatus.Equals("Gäst"))
            { playerStatus = 5; }
            //      else if(status.Equals(null))
            //      { playerStatus = selectedPlayer.membershipStatus; }
            //liknande kod för att registrera om spelaren betalt avgift
            string payedFee = cbMembershipFee.GetItemText(cbMembershipFee.SelectedItem);
            bool memberFee = true;
            if (payedFee.Equals("Betald"))
            { memberFee = true; }
            else
            {
                memberFee = false;
            }
            bool sex = true;
            if (payedFee.Equals("Man"))
            { memberFee = true; }
            else
            {
                memberFee = false;
            }
            //Skapa GolfID
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            selectedPlayer = (Player)lbPlayerChart.SelectedItem;                        
            string stringGolfId = txtGolfId.Text + "001"; //Här har du golfID + 001           
            int golfId = Convert.ToInt32(stringGolfId); //här får du ut det som int = 851217001 
            
            conn.Open();
            string query = "SELECT max(golfid) FROM player WHERE golfid >= " + txtGolfId.Text + "001" + "AND golfid <= " + txtGolfId.Text + "999";
            NpgsqlCommand command1 = new NpgsqlCommand(query, conn);
            object objHighestGolfId = command1.ExecuteScalar(); //Tar ut högsta värdet i [valtpersonummer] + [xxx]
            if (!string.IsNullOrEmpty("" + objHighestGolfId)) //Om värdet inte är null, utför detta:
            {
                int highestGolfId = Convert.ToInt32(objHighestGolfId); //gör om object till typ int 851212003
                while (golfId <= highestGolfId) //medan [personummer] + [xxx] är under valt värde:
                {
                    golfId++; //lägg till ett nummer till på slutet
                }    
            }            
                              
            try
            {                                
                NpgsqlCommand command2 = new NpgsqlCommand("INSERT INTO player (golfid, playerstatus_id, firstname, lastname, address, streetnumber, zipcode, mobile, email, membershipfee, handicap, sex) VALUES (" + golfId + " , " + playerStatus + " , '" + txtFirstName.Text + "' , '" + txtLastName.Text + "' , '" + txtAddress.Text + "' , '" + txtStreetNumber.Text + "' , " + Convert.ToInt32(txtZipCode.Text) + " , '" + txtMobile.Text + "' , '" + txtEmail.Text + "' , '" + memberFee + "' ," + Convert.ToDouble(txtHandicap.Text) + " , " + sex + " )", conn);
                int antal2 = command2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vänligen fyll i samtliga fält korrekt");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            lbPlayerChart.DataSource = Methods.GetPlayers();
           // lbMainPagePlayers.DataSource = Methods.GetPlayers();

          //  label1.Text = ((Form1)frm1).textBox1.Text;
  

            //Här bör även kod för att uppdatera mainsidan läggas in
           // MainPage.lbMainPagePlayers.DataSource = l

        }
    }
}
