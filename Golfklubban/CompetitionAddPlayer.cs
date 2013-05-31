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
    public partial class CompetitionAddPlayer : Form
    {        
        public CompetitionAddPlayer()
        {
            InitializeComponent();
        }

        
        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void txtAvbokningsdatum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnmälningsdatum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void txtStopptid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSkapa_tävling_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tävlingen har skapats");
            this.Close();
        }
    }
}
