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
            this.tsmPlayerAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPlayerDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTeamView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTeamAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTeamDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCompetitionAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCompetitionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lbMainPagePlayers = new System.Windows.Forms.ListBox();
            this.lbAvailibleTimes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCoupleView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCoupleAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCoupleDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCompetitionAddPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.medlemmarToolStripMenuItem,
            this.parToolStripMenuItem,
            this.lagToolStripMenuItem,
            this.tävlingarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
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
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // stängToolStripMenuItem
            // 
            this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
            this.stängToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stängToolStripMenuItem.Text = "Stäng";
            this.stängToolStripMenuItem.Click += new System.EventHandler(this.stängToolStripMenuItem_Click);
            // 
            // medlemmarToolStripMenuItem
            // 
            this.medlemmarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPlayerChange,
            this.tsmPlayerAdd,
            this.tsmPlayerDelete});
            this.medlemmarToolStripMenuItem.Name = "medlemmarToolStripMenuItem";
            this.medlemmarToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.medlemmarToolStripMenuItem.Text = "Medlemmar";
            // 
            // tsmPlayerChange
            // 
            this.tsmPlayerChange.Name = "tsmPlayerChange";
            this.tsmPlayerChange.Size = new System.Drawing.Size(216, 22);
            this.tsmPlayerChange.Text = "Visa/Ändra medlemmsinfo";
            this.tsmPlayerChange.Click += new System.EventHandler(this.visaMedlemmarToolStripMenuItem_Click);
            // 
            // tsmPlayerAdd
            // 
            this.tsmPlayerAdd.Name = "tsmPlayerAdd";
            this.tsmPlayerAdd.Size = new System.Drawing.Size(216, 22);
            this.tsmPlayerAdd.Text = "Lägg till ny medlem";
            this.tsmPlayerAdd.Click += new System.EventHandler(this.läggTillMedlemToolStripMenuItem_Click);
            // 
            // tsmPlayerDelete
            // 
            this.tsmPlayerDelete.Name = "tsmPlayerDelete";
            this.tsmPlayerDelete.Size = new System.Drawing.Size(216, 22);
            this.tsmPlayerDelete.Text = "Ta bort medlem";
            // 
            // lagToolStripMenuItem
            // 
            this.lagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTeamView,
            this.tsmTeamAdd,
            this.tsmTeamDelete});
            this.lagToolStripMenuItem.Name = "lagToolStripMenuItem";
            this.lagToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.lagToolStripMenuItem.Text = "Lag";
            // 
            // tsmTeamView
            // 
            this.tsmTeamView.Name = "tsmTeamView";
            this.tsmTeamView.Size = new System.Drawing.Size(159, 22);
            this.tsmTeamView.Text = "Visa lag";
            this.tsmTeamView.Click += new System.EventHandler(this.visaLagToolStripMenuItem_Click);
            // 
            // tsmTeamAdd
            // 
            this.tsmTeamAdd.Name = "tsmTeamAdd";
            this.tsmTeamAdd.Size = new System.Drawing.Size(159, 22);
            this.tsmTeamAdd.Text = "Lägg till nytt lag";
            // 
            // tsmTeamDelete
            // 
            this.tsmTeamDelete.Name = "tsmTeamDelete";
            this.tsmTeamDelete.Size = new System.Drawing.Size(159, 22);
            this.tsmTeamDelete.Text = "Ta bort lag";
            // 
            // tävlingarToolStripMenuItem
            // 
            this.tävlingarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCompetitionAddPlayer,
            this.tsmCompetitionAdd,
            this.tsmCompetitionDelete});
            this.tävlingarToolStripMenuItem.Name = "tävlingarToolStripMenuItem";
            this.tävlingarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tävlingarToolStripMenuItem.Text = "Tävling";
            // 
            // tsmCompetitionAdd
            // 
            this.tsmCompetitionAdd.Name = "tsmCompetitionAdd";
            this.tsmCompetitionAdd.Size = new System.Drawing.Size(171, 22);
            this.tsmCompetitionAdd.Text = "Lägg till ny tävling";
            // 
            // tsmCompetitionDelete
            // 
            this.tsmCompetitionDelete.Name = "tsmCompetitionDelete";
            this.tsmCompetitionDelete.Size = new System.Drawing.Size(171, 22);
            this.tsmCompetitionDelete.Text = "Ta bort tävling";
            // 
            // lbMainPagePlayers
            // 
            this.lbMainPagePlayers.FormattingEnabled = true;
            this.lbMainPagePlayers.Location = new System.Drawing.Point(15, 55);
            this.lbMainPagePlayers.Name = "lbMainPagePlayers";
            this.lbMainPagePlayers.Size = new System.Drawing.Size(214, 316);
            this.lbMainPagePlayers.TabIndex = 2;
            
            // 
            // lbAvailibleTimes
            // 
            this.lbAvailibleTimes.FormattingEnabled = true;
            this.lbAvailibleTimes.Location = new System.Drawing.Point(292, 120);
            this.lbAvailibleTimes.Name = "lbAvailibleTimes";
            this.lbAvailibleTimes.Size = new System.Drawing.Size(148, 251);
            this.lbAvailibleTimes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spelare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tillgängliga tider";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Genomför bokning";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(292, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(292, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Timme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datum:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // parToolStripMenuItem
            // 
            this.parToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCoupleView,
            this.tsmCoupleAdd,
            this.tsmCoupleDelete});
            this.parToolStripMenuItem.Name = "parToolStripMenuItem";
            this.parToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.parToolStripMenuItem.Text = "Par";
            // 
            // tsmCoupleView
            // 
            this.tsmCoupleView.Name = "tsmCoupleView";
            this.tsmCoupleView.Size = new System.Drawing.Size(152, 22);
            this.tsmCoupleView.Text = "Visa par";
            // 
            // tsmCoupleAdd
            // 
            this.tsmCoupleAdd.Name = "tsmCoupleAdd";
            this.tsmCoupleAdd.Size = new System.Drawing.Size(152, 22);
            this.tsmCoupleAdd.Text = "Lägg till par";
            // 
            // tsmCoupleDelete
            // 
            this.tsmCoupleDelete.Name = "tsmCoupleDelete";
            this.tsmCoupleDelete.Size = new System.Drawing.Size(152, 22);
            this.tsmCoupleDelete.Text = "Ta bort par";
            // 
            // tsmCompetitionAddPlayer
            // 
            this.tsmCompetitionAddPlayer.Name = "tsmCompetitionAddPlayer";
            this.tsmCompetitionAddPlayer.Size = new System.Drawing.Size(171, 22);
            this.tsmCompetitionAddPlayer.Text = "Boka inför tävling";
            this.tsmCompetitionAddPlayer.Click += new System.EventHandler(this.bokaInförTävlingToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 409);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAvailibleTimes);
            this.Controls.Add(this.lbMainPagePlayers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Golfklubban";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ToolStripMenuItem tsmPlayerAdd;
        private System.Windows.Forms.ToolStripMenuItem lagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmTeamView;
        private System.Windows.Forms.ToolStripMenuItem tsmTeamAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmCompetitionAdd;
        private System.Windows.Forms.ListBox lbMainPagePlayers;
        private System.Windows.Forms.ListBox lbAvailibleTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem tsmPlayerDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmTeamDelete;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCompetitionDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem parToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCoupleView;
        private System.Windows.Forms.ToolStripMenuItem tsmCoupleAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmCoupleDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmCompetitionAddPlayer;


    }
}

