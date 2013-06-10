namespace Golfklubban
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stängToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medlemmarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlayerChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCompetitionAddPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.lagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTeamView = new System.Windows.Forms.ToolStripMenuItem();
            this.lbMainPagePlayers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBooking = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbTimes = new System.Windows.Forms.ListBox();
            this.lbBookedPlayers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.txtSearchGolfId = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.Button();
            this.txtGetPlayers = new System.Windows.Forms.Button();
            this.txtDropPlayer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.medlemmarToolStripMenuItem,
            this.tävlingarToolStripMenuItem,
            this.lagToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.stängToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // stängToolStripMenuItem
            // 
            this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
            this.stängToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.stängToolStripMenuItem.Text = "Stäng";
            this.stängToolStripMenuItem.Click += new System.EventHandler(this.stängToolStripMenuItem_Click);
            // 
            // medlemmarToolStripMenuItem
            // 
            this.medlemmarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPlayerChange});
            this.medlemmarToolStripMenuItem.Name = "medlemmarToolStripMenuItem";
            this.medlemmarToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.medlemmarToolStripMenuItem.Text = "Medlemmar";
            // 
            // tsmPlayerChange
            // 
            this.tsmPlayerChange.Name = "tsmPlayerChange";
            this.tsmPlayerChange.Size = new System.Drawing.Size(184, 22);
            this.tsmPlayerChange.Text = "Hantera medlemmar";
            this.tsmPlayerChange.Click += new System.EventHandler(this.visaMedlemmarToolStripMenuItem_Click);
            // 
            // tävlingarToolStripMenuItem
            // 
            this.tävlingarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCompetitionAddPlayer});
            this.tävlingarToolStripMenuItem.Name = "tävlingarToolStripMenuItem";
            this.tävlingarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tävlingarToolStripMenuItem.Text = "Tävling";
            // 
            // tsmCompetitionAddPlayer
            // 
            this.tsmCompetitionAddPlayer.Name = "tsmCompetitionAddPlayer";
            this.tsmCompetitionAddPlayer.Size = new System.Drawing.Size(155, 22);
            this.tsmCompetitionAddPlayer.Text = "Hantera tävling";
            this.tsmCompetitionAddPlayer.Click += new System.EventHandler(this.bokaInförTävlingToolStripMenuItem_Click);
            // 
            // lagToolStripMenuItem
            // 
            this.lagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTeamView});
            this.lagToolStripMenuItem.Name = "lagToolStripMenuItem";
            this.lagToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.lagToolStripMenuItem.Text = "Lag";
            // 
            // tsmTeamView
            // 
            this.tsmTeamView.Name = "tsmTeamView";
            this.tsmTeamView.Size = new System.Drawing.Size(114, 22);
            this.tsmTeamView.Text = "Visa lag";
            this.tsmTeamView.Click += new System.EventHandler(this.visaLagToolStripMenuItem_Click);
            // 
            // lbMainPagePlayers
            // 
            this.lbMainPagePlayers.FormattingEnabled = true;
            this.lbMainPagePlayers.Location = new System.Drawing.Point(21, 250);
            this.lbMainPagePlayers.Name = "lbMainPagePlayers";
            this.lbMainPagePlayers.Size = new System.Drawing.Size(228, 212);
            this.lbMainPagePlayers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spelare";
            // 
            // txtBooking
            // 
            this.txtBooking.Location = new System.Drawing.Point(440, 471);
            this.txtBooking.Name = "txtBooking";
            this.txtBooking.Size = new System.Drawing.Size(106, 23);
            this.txtBooking.TabIndex = 4;
            this.txtBooking.Text = "Genomför bokning";
            this.txtBooking.UseVisualStyleBackColor = true;
            this.txtBooking.Click += new System.EventHandler(this.txtBooking_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(375, 66);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // lbTimes
            // 
            this.lbTimes.FormattingEnabled = true;
            this.lbTimes.Location = new System.Drawing.Point(375, 265);
            this.lbTimes.Name = "lbTimes";
            this.lbTimes.Size = new System.Drawing.Size(171, 186);
            this.lbTimes.TabIndex = 6;
            this.lbTimes.SelectedIndexChanged += new System.EventHandler(this.lbTimes_SelectedIndexChanged);
            // 
            // lbBookedPlayers
            // 
            this.lbBookedPlayers.FormattingEnabled = true;
            this.lbBookedPlayers.Location = new System.Drawing.Point(642, 66);
            this.lbBookedPlayers.Name = "lbBookedPlayers";
            this.lbBookedPlayers.Size = new System.Drawing.Size(181, 95);
            this.lbBookedPlayers.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Efternamn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Förnamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Golf-ID";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(149, 108);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchLastName.TabIndex = 23;
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(21, 109);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchFirstName.TabIndex = 22;
            // 
            // txtSearchGolfId
            // 
            this.txtSearchGolfId.Location = new System.Drawing.Point(21, 55);
            this.txtSearchGolfId.Name = "txtSearchGolfId";
            this.txtSearchGolfId.Size = new System.Drawing.Size(100, 20);
            this.txtSearchGolfId.TabIndex = 21;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(174, 149);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(75, 23);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.Text = "Sök Spelare";
            this.txtSearch.UseVisualStyleBackColor = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // txtGetPlayers
            // 
            this.txtGetPlayers.Location = new System.Drawing.Point(854, 66);
            this.txtGetPlayers.Name = "txtGetPlayers";
            this.txtGetPlayers.Size = new System.Drawing.Size(106, 23);
            this.txtGetPlayers.TabIndex = 27;
            this.txtGetPlayers.Text = "Hämta spelare";
            this.txtGetPlayers.UseVisualStyleBackColor = true;
            this.txtGetPlayers.Click += new System.EventHandler(this.txtGetPlayers_Click);
            // 
            // txtDropPlayer
            // 
            this.txtDropPlayer.Location = new System.Drawing.Point(733, 183);
            this.txtDropPlayer.Name = "txtDropPlayer";
            this.txtDropPlayer.Size = new System.Drawing.Size(90, 23);
            this.txtDropPlayer.TabIndex = 28;
            this.txtDropPlayer.Text = "Avboka spelare";
            this.txtDropPlayer.UseVisualStyleBackColor = true;
            this.txtDropPlayer.Click += new System.EventHandler(this.txtDropPlayer_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 615);
            this.Controls.Add(this.txtDropPlayer);
            this.Controls.Add(this.txtGetPlayers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchLastName);
            this.Controls.Add(this.txtSearchFirstName);
            this.Controls.Add(this.txtSearchGolfId);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbBookedPlayers);
            this.Controls.Add(this.lbTimes);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtBooking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMainPagePlayers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Golfklubban";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stängToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medlemmarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPlayerChange;
        private System.Windows.Forms.ToolStripMenuItem lagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmTeamView;
        public System.Windows.Forms.ListBox lbMainPagePlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtBooking;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCompetitionAddPlayer;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox lbTimes;
        private System.Windows.Forms.ListBox lbBookedPlayers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.TextBox txtSearchGolfId;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.Button txtGetPlayers;
        private System.Windows.Forms.Button txtDropPlayer;


    }
}

