using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Golfklubban
{
    public partial class PlayerChart : Form
    {
        public PlayerChart()
        {
            InitializeComponent();
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Medlemmen har registrerats!");
            this.Close(); //stänger slutligen fönstret
        }
    }
}
