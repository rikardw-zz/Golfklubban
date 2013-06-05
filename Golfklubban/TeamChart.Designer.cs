namespace Golfklubban
{
    partial class TeamChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lbPlayer = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTeamChart = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.lbPlayerInTeam = new System.Windows.Forms.ListBox();
            this.btnDeletePlayerFromTeam = new System.Windows.Forms.Button();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(84, 336);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(111, 23);
            this.btnAddPlayer.TabIndex = 9;
            this.btnAddPlayer.Text = "Lägg till spelare";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lbPlayer
            // 
            this.lbPlayer.FormattingEnabled = true;
            this.lbPlayer.Location = new System.Drawing.Point(17, 31);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(178, 277);
            this.lbPlayer.TabIndex = 4;
            this.lbPlayer.SelectedIndexChanged += new System.EventHandler(this.lbPlayer_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPlayer);
            this.groupBox2.Controls.Add(this.btnAddPlayer);
            this.groupBox2.Location = new System.Drawing.Point(436, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 380);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spelare";
            // 
            // lbTeamChart
            // 
            this.lbTeamChart.FormattingEnabled = true;
            this.lbTeamChart.Location = new System.Drawing.Point(21, 78);
            this.lbTeamChart.Name = "lbTeamChart";
            this.lbTeamChart.Size = new System.Drawing.Size(186, 238);
            this.lbTeamChart.TabIndex = 4;
            this.lbTeamChart.SelectedIndexChanged += new System.EventHandler(this.lbTeamChart_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lagnamn";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(21, 37);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(170, 20);
            this.txtTeamName.TabIndex = 8;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(221, 34);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(111, 23);
            this.btnCreateTeam.TabIndex = 9;
            this.btnCreateTeam.Text = "Skapa lagnamn";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // lbPlayerInTeam
            // 
            this.lbPlayerInTeam.FormattingEnabled = true;
            this.lbPlayerInTeam.Location = new System.Drawing.Point(21, 336);
            this.lbPlayerInTeam.Name = "lbPlayerInTeam";
            this.lbPlayerInTeam.Size = new System.Drawing.Size(186, 95);
            this.lbPlayerInTeam.TabIndex = 10;
            // 
            // btnDeletePlayerFromTeam
            // 
            this.btnDeletePlayerFromTeam.Location = new System.Drawing.Point(221, 336);
            this.btnDeletePlayerFromTeam.Name = "btnDeletePlayerFromTeam";
            this.btnDeletePlayerFromTeam.Size = new System.Drawing.Size(111, 23);
            this.btnDeletePlayerFromTeam.TabIndex = 11;
            this.btnDeletePlayerFromTeam.Text = "Ta bort spelare";
            this.btnDeletePlayerFromTeam.UseVisualStyleBackColor = true;
            this.btnDeletePlayerFromTeam.Click += new System.EventHandler(this.btnDeletePlayerFromTeam_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Location = new System.Drawing.Point(221, 78);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteTeam.TabIndex = 12;
            this.btnDeleteTeam.Text = "Ta bort lag";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
           // this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteTeam);
            this.groupBox1.Controls.Add(this.btnDeletePlayerFromTeam);
            this.groupBox1.Controls.Add(this.lbPlayerInTeam);
            this.groupBox1.Controls.Add(this.btnCreateTeam);
            this.groupBox1.Controls.Add(this.txtTeamName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbTeamChart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 477);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skapa nytt lag";
            // 
            // TeamChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "TeamChart";
            this.Text = "Lag";
            this.Load += new System.EventHandler(this.TeamChart_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.ListBox lbPlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbTeamChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.ListBox lbPlayerInTeam;
        private System.Windows.Forms.Button btnDeletePlayerFromTeam;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.GroupBox groupBox1;



    }
}