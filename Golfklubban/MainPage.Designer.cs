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
            this.lbMainPagePlayers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBooking = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbTimes = new System.Windows.Forms.ListBox();
            this.lbBookedPlayers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.txtSearchGolfId = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.Button();
            this.txtDropPlayer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGuestSex = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGuestGolfId = new System.Windows.Forms.TextBox();
            this.txtGuestFirstName = new System.Windows.Forms.TextBox();
            this.btnRegisterGuest = new System.Windows.Forms.Button();
            this.txtGuestLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGuestMobilePhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGuestHandicap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaintenanceEnd = new System.Windows.Forms.TextBox();
            this.txtMaintenanceStart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaintenanceDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMainPagePlayers
            // 
            this.lbMainPagePlayers.FormattingEnabled = true;
            this.lbMainPagePlayers.Location = new System.Drawing.Point(36, 58);
            this.lbMainPagePlayers.Name = "lbMainPagePlayers";
            this.lbMainPagePlayers.Size = new System.Drawing.Size(228, 303);
            this.lbMainPagePlayers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spelare tillgängliga:";
            // 
            // txtBooking
            // 
            this.txtBooking.Location = new System.Drawing.Point(396, 359);
            this.txtBooking.Name = "txtBooking";
            this.txtBooking.Size = new System.Drawing.Size(94, 23);
            this.txtBooking.TabIndex = 4;
            this.txtBooking.Text = "Boka spelare";
            this.txtBooking.UseVisualStyleBackColor = true;
            this.txtBooking.Click += new System.EventHandler(this.txtBooking_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(319, 58);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // lbTimes
            // 
            this.lbTimes.FormattingEnabled = true;
            this.lbTimes.Location = new System.Drawing.Point(319, 232);
            this.lbTimes.Name = "lbTimes";
            this.lbTimes.Size = new System.Drawing.Size(171, 121);
            this.lbTimes.TabIndex = 6;
            this.lbTimes.SelectedIndexChanged += new System.EventHandler(this.lbTimes_SelectedIndexChanged);
            // 
            // lbBookedPlayers
            // 
            this.lbBookedPlayers.FormattingEnabled = true;
            this.lbBookedPlayers.Location = new System.Drawing.Point(319, 411);
            this.lbBookedPlayers.Name = "lbBookedPlayers";
            this.lbBookedPlayers.Size = new System.Drawing.Size(171, 69);
            this.lbBookedPlayers.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Golf-ID";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(89, 35);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchLastName.TabIndex = 23;
            // 
            // txtSearchGolfId
            // 
            this.txtSearchGolfId.Location = new System.Drawing.Point(6, 35);
            this.txtSearchGolfId.Name = "txtSearchGolfId";
            this.txtSearchGolfId.Size = new System.Drawing.Size(78, 20);
            this.txtSearchGolfId.TabIndex = 21;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(75, 23);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.Text = "Sök Spelare";
            this.txtSearch.UseVisualStyleBackColor = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // txtDropPlayer
            // 
            this.txtDropPlayer.Location = new System.Drawing.Point(396, 486);
            this.txtDropPlayer.Name = "txtDropPlayer";
            this.txtDropPlayer.Size = new System.Drawing.Size(94, 23);
            this.txtDropPlayer.TabIndex = 28;
            this.txtDropPlayer.Text = "Avboka spelare";
            this.txtDropPlayer.UseVisualStyleBackColor = true;
            this.txtDropPlayer.Click += new System.EventHandler(this.txtDropPlayer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bokade spelare";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGuestSex);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtGuestGolfId);
            this.groupBox2.Controls.Add(this.txtGuestFirstName);
            this.groupBox2.Controls.Add(this.btnRegisterGuest);
            this.groupBox2.Controls.Add(this.txtGuestLastName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtGuestMobilePhone);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtGuestHandicap);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(610, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 308);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrera gästspelare";
            // 
            // cbGuestSex
            // 
            this.cbGuestSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuestSex.FormattingEnabled = true;
            this.cbGuestSex.Items.AddRange(new object[] {
            "Man",
            "Kvinna"});
            this.cbGuestSex.Location = new System.Drawing.Point(18, 232);
            this.cbGuestSex.Name = "cbGuestSex";
            this.cbGuestSex.Size = new System.Drawing.Size(100, 21);
            this.cbGuestSex.TabIndex = 345;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 346;
            this.label12.Text = "Kön";
            // 
            // txtGuestGolfId
            // 
            this.txtGuestGolfId.ForeColor = System.Drawing.Color.Silver;
            this.txtGuestGolfId.Location = new System.Drawing.Point(18, 68);
            this.txtGuestGolfId.MaxLength = 9;
            this.txtGuestGolfId.Name = "txtGuestGolfId";
            this.txtGuestGolfId.Size = new System.Drawing.Size(100, 20);
            this.txtGuestGolfId.TabIndex = 35;
            this.txtGuestGolfId.Text = "YYMMDDXXX";
            this.txtGuestGolfId.Click += new System.EventHandler(this.txtGuestGolfId_Click);
            // 
            // txtGuestFirstName
            // 
            this.txtGuestFirstName.Location = new System.Drawing.Point(18, 32);
            this.txtGuestFirstName.Name = "txtGuestFirstName";
            this.txtGuestFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtGuestFirstName.TabIndex = 33;
            // 
            // btnRegisterGuest
            // 
            this.btnRegisterGuest.Location = new System.Drawing.Point(43, 269);
            this.btnRegisterGuest.Name = "btnRegisterGuest";
            this.btnRegisterGuest.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterGuest.TabIndex = 43;
            this.btnRegisterGuest.Text = "Registrera";
            this.btnRegisterGuest.UseVisualStyleBackColor = true;
            this.btnRegisterGuest.Click += new System.EventHandler(this.btnRegisterGuest_Click);
            // 
            // txtGuestLastName
            // 
            this.txtGuestLastName.Location = new System.Drawing.Point(18, 154);
            this.txtGuestLastName.Name = "txtGuestLastName";
            this.txtGuestLastName.Size = new System.Drawing.Size(100, 20);
            this.txtGuestLastName.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Handicap";
            // 
            // txtGuestMobilePhone
            // 
            this.txtGuestMobilePhone.Location = new System.Drawing.Point(18, 190);
            this.txtGuestMobilePhone.Name = "txtGuestMobilePhone";
            this.txtGuestMobilePhone.Size = new System.Drawing.Size(100, 20);
            this.txtGuestMobilePhone.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Telefon";
            // 
            // txtGuestHandicap
            // 
            this.txtGuestHandicap.Location = new System.Drawing.Point(18, 110);
            this.txtGuestHandicap.Name = "txtGuestHandicap";
            this.txtGuestHandicap.Size = new System.Drawing.Size(100, 20);
            this.txtGuestHandicap.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "GolfID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Förnamn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Efternamn";
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
            this.menuStrip1.Size = new System.Drawing.Size(1105, 24);
            this.menuStrip1.TabIndex = 47;
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
            // 
            // stängToolStripMenuItem
            // 
            this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
            this.stängToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.stängToolStripMenuItem.Text = "Stäng";
            this.stängToolStripMenuItem.Click += new System.EventHandler(this.stängToolStripMenuItem_Click_1);
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
            this.tsmPlayerChange.Click += new System.EventHandler(this.tsmPlayerChange_Click);
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
            this.tsmCompetitionAddPlayer.Click += new System.EventHandler(this.tsmCompetitionAddPlayer_Click);
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.txtSearchGolfId);
            this.groupBox1.Controls.Add(this.txtSearchLastName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(36, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 92);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök spelare";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Visa alla spelare";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnMaintenance);
            this.groupBox3.Controls.Add(this.txtStaffId);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtMaintenanceEnd);
            this.groupBox3.Controls.Add(this.txtMaintenanceStart);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMaintenanceDate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(779, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 210);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Boka tid för banskötsel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Sluttid";
            // 
            // txtMaintenanceEnd
            // 
            this.txtMaintenanceEnd.ForeColor = System.Drawing.Color.Silver;
            this.txtMaintenanceEnd.Location = new System.Drawing.Point(9, 110);
            this.txtMaintenanceEnd.Name = "txtMaintenanceEnd";
            this.txtMaintenanceEnd.Size = new System.Drawing.Size(112, 20);
            this.txtMaintenanceEnd.TabIndex = 0;
            this.txtMaintenanceEnd.Text = "HH:MM";
            this.txtMaintenanceEnd.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // txtMaintenanceStart
            // 
            this.txtMaintenanceStart.ForeColor = System.Drawing.Color.Silver;
            this.txtMaintenanceStart.Location = new System.Drawing.Point(6, 68);
            this.txtMaintenanceStart.Name = "txtMaintenanceStart";
            this.txtMaintenanceStart.Size = new System.Drawing.Size(112, 20);
            this.txtMaintenanceStart.TabIndex = 0;
            this.txtMaintenanceStart.Text = "HH:MM";
            this.txtMaintenanceStart.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Starttid";
            // 
            // txtMaintenanceDate
            // 
            this.txtMaintenanceDate.ForeColor = System.Drawing.Color.Silver;
            this.txtMaintenanceDate.Location = new System.Drawing.Point(6, 32);
            this.txtMaintenanceDate.Name = "txtMaintenanceDate";
            this.txtMaintenanceDate.Size = new System.Drawing.Size(112, 20);
            this.txtMaintenanceDate.TabIndex = 0;
            this.txtMaintenanceDate.Text = "YYYY-MM-DD";
            this.txtMaintenanceDate.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Datum";
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(24, 181);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(94, 23);
            this.btnMaintenance.TabIndex = 39;
            this.btnMaintenance.Text = "Boka Underhåll";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Personal Id";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(6, 149);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(112, 20);
            this.txtStaffId.TabIndex = 52;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMainPagePlayers);
            this.Controls.Add(this.txtBooking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtDropPlayer);
            this.Controls.Add(this.lbBookedPlayers);
            this.Controls.Add(this.lbTimes);
            this.Name = "MainPage";
            this.Text = "Golfklubban";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbMainPagePlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtBooking;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox lbTimes;
        private System.Windows.Forms.ListBox lbBookedPlayers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.TextBox txtSearchGolfId;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.Button txtDropPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbGuestSex;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGuestGolfId;
        private System.Windows.Forms.TextBox txtGuestFirstName;
        private System.Windows.Forms.Button btnRegisterGuest;
        private System.Windows.Forms.TextBox txtGuestLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGuestMobilePhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGuestHandicap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stängToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medlemmarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPlayerChange;
        private System.Windows.Forms.ToolStripMenuItem tävlingarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCompetitionAddPlayer;
        private System.Windows.Forms.ToolStripMenuItem lagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmTeamView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaintenanceStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaintenanceDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMaintenanceEnd;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStaffId;


    }
}

