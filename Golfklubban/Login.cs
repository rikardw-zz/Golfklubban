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
    public partial class Login : Form
    {
        Staff staffLogin = new Staff();   

        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {                       
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp3vt13;User Id=grp3vt13;Password=XmFGFwX6t;SSL=true");
                try
                {
                    conn.Open();
                    NpgsqlCommand command1 = new NpgsqlCommand("SELECT password, firstname FROM staff WHERE firstname = ('" + txtUser.Text + "')", conn);     
                    //hämtar alla användare som heter t.ex "Björn", detta kan ersättas med unikare saker, t.ex mail
                    object objPassword = command1.ExecuteScalar(); //= är lösenordet för Björn
                    string stringPassword = Convert.ToString(objPassword);

                    if (!string.IsNullOrEmpty("" + stringPassword))
                    {
                        if (stringPassword == txtPassword.Text)
                        {
                            MainPage mp = new MainPage();
                            mp.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Användarnamn eller lösenord felaktigt. vänligen försök igen (lösen)");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Användarnamn eller lösenord felaktigt. vänligen försök igen (lösen/användarnamn)");                    
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
    }    
}
