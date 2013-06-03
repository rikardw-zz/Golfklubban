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
    public partial class PlayerChart : Form
    {
        public PlayerChart()
        {
            InitializeComponent();
        }
        private Player selectedPlayer;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*//kod för att hämta värdet ifrån combobox. Efter det så jämför den detta värde mot orden inom " ". tilldelar därefter playerstatus en siffra som 
            //går att lägga in i databasen

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
            //      else if(status.Equals(null))
            //      { playerStatus = selectedPlayer.membershipStatus; }


            //liknande kod för att registrera om spelaren betalt avgift
            string fee = cbMembershipFee.GetItemText(cbMembershipFee.SelectedItem);
            bool memberfee = selectedPlayer.membershipFee;
            if (fee.Equals("Betald"))
            { memberfee = true; }
            else
            {
                memberfee = false;
            }



            Methods.UpdatePlayer(selectedPlayer.golfId, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtStreetNumber.Text,
            Convert.ToInt32(txtZipCode.Text), txtMobilePhone.Text, txtEmail.Text, Convert.ToDouble(txtHandicap.Text), playerStatus, memberfee);
            lbPlayerChart.DataSource = Methods.GetPlayers();*/
        }

        private void PlayerChart_Load(object sender, EventArgs e)
        {
            lbPlayerChart.DataSource = Methods.GetPlayers();
        }

        private void lbPlayerChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPlayer = (Player)lbPlayerChart.SelectedItem;
            txtFirstName.Text = selectedPlayer.firstName;
            txtLastName.Text = selectedPlayer.lastName;
            txtGolfID.Text = selectedPlayer.golfId.ToString();
            txtMobile.Text = selectedPlayer.mobilePhone;
            txtStreetNumber.Text = selectedPlayer.streetNumber;
            txtZipCode.Text = selectedPlayer.zipCode.ToString();
            txtEmail.Text = selectedPlayer.eMail;
            txtAddress.Text = selectedPlayer.address;
            txtHandicap.Text = selectedPlayer.handicap.ToString();
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string chosenStatus = cbMembershipStatus.GetItemText(cbMembershipStatus.SelectedItem); //hämtar info av valt item i comboboxen
            int playerStatus = selectedPlayer.membershipStatus;
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
            bool memberFee = selectedPlayer.membershipFee;
            if (payedFee.Equals("Betald"))
            { memberFee = true; }
            else
            {
                memberFee = false;
            }
            bool sex = selectedPlayer.sex;
            if (payedFee.Equals("Man"))
            { memberFee = true; }
            else
            {
                memberFee = false;
            }

            selectedPlayer = (Player)lbPlayerChart.SelectedItem;
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
            try
            {                
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO player (golfid, playerstatus_id, firstname, lastname, address, streetnumber, zipcode, mobile, email, membershipfee, handicap, sex) VALUES (" + Convert.ToInt32(txtGolfID.Text) + " , " + playerStatus + " , '" + txtFirstName.Text + "' , '" + txtLastName.Text + "' , '" + txtAddress.Text + "' , '" + txtStreetNumber.Text + "' , " + Convert.ToInt32(txtZipCode.Text) + " , '" + txtMobile.Text + "' , '" + txtEmail.Text + "' , '" + memberFee + "' ," + Convert.ToDouble(txtHandicap.Text) + " , " + sex + " )", conn);
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
    }
}
