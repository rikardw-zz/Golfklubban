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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //test
        }

        private void button1_Click(object sender, EventArgs e)
        {
                                    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
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
    }
}
