namespace Golfklubban
{
    partial class CoupleChart
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lbPlayer = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCoup = new System.Windows.Forms.Button();
            this.btnCreateCouple = new System.Windows.Forms.Button();
            this.btnDeletePlayerFromCouple = new System.Windows.Forms.Button();
            this.txtCoupleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPlayerInCouple = new System.Windows.Forms.ListBox();
            this.lbCoupleChart = new System.Windows.Forms.ListBox();
            this.btnDeleteCouple = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddPlayer);
            this.groupBox2.Controls.Add(this.lbPlayer);
            this.groupBox2.Location = new System.Drawing.Point(437, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 338);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spelare";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(83, 292);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(113, 23);
            this.btnAddPlayer.TabIndex = 5;
            this.btnAddPlayer.Text = "Lägg till spelare";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // lbPlayer
            // 
            this.lbPlayer.FormattingEnabled = true;
            this.lbPlayer.Location = new System.Drawing.Point(21, 34);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(186, 238);
            this.lbPlayer.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteCoup);
            this.groupBox1.Controls.Add(this.btnCreateCouple);
            this.groupBox1.Controls.Add(this.btnDeletePlayerFromCouple);
            this.groupBox1.Controls.Add(this.txtCoupleName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbPlayerInCouple);
            this.groupBox1.Controls.Add(this.lbCoupleChart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 530);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skapa nytt par";
            // 
            // btnDeleteCoup
            // 
            this.btnDeleteCoup.Location = new System.Drawing.Point(225, 97);
            this.btnDeleteCoup.Name = "btnDeleteCoup";
            this.btnDeleteCoup.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCoup.TabIndex = 11;
            this.btnDeleteCoup.Text = "Ta bort par";
            this.btnDeleteCoup.UseVisualStyleBackColor = true;
            // 
            // btnCreateCouple
            // 
            this.btnCreateCouple.Location = new System.Drawing.Point(225, 35);
            this.btnCreateCouple.Name = "btnCreateCouple";
            this.btnCreateCouple.Size = new System.Drawing.Size(108, 23);
            this.btnCreateCouple.TabIndex = 10;
            this.btnCreateCouple.Text = "Skapa parnamn";
            this.btnCreateCouple.UseVisualStyleBackColor = true;
            this.btnCreateCouple.Click += new System.EventHandler(this.btnCreateCouple_Click);
            // 
            // btnDeletePlayerFromCouple
            // 
            this.btnDeletePlayerFromCouple.Location = new System.Drawing.Point(243, 354);
            this.btnDeletePlayerFromCouple.Name = "btnDeletePlayerFromCouple";
            this.btnDeletePlayerFromCouple.Size = new System.Drawing.Size(111, 23);
            this.btnDeletePlayerFromCouple.TabIndex = 9;
            this.btnDeletePlayerFromCouple.Text = "Ta bort spelare";
            this.btnDeletePlayerFromCouple.UseVisualStyleBackColor = true;
            // 
            // txtCoupleName
            // 
            this.txtCoupleName.Location = new System.Drawing.Point(21, 37);
            this.txtCoupleName.Name = "txtCoupleName";
            this.txtCoupleName.Size = new System.Drawing.Size(170, 20);
            this.txtCoupleName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parnamn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Spelare";
            // 
            // lbPlayerInCouple
            // 
            this.lbPlayerInCouple.FormattingEnabled = true;
            this.lbPlayerInCouple.Location = new System.Drawing.Point(21, 351);
            this.lbPlayerInCouple.Name = "lbPlayerInCouple";
            this.lbPlayerInCouple.Size = new System.Drawing.Size(186, 108);
            this.lbPlayerInCouple.TabIndex = 3;
            // 
            // lbCoupleChart
            // 
            this.lbCoupleChart.FormattingEnabled = true;
            this.lbCoupleChart.Location = new System.Drawing.Point(21, 87);
            this.lbCoupleChart.Name = "lbCoupleChart";
            this.lbCoupleChart.Size = new System.Drawing.Size(186, 238);
            this.lbCoupleChart.TabIndex = 4;
            // 
            // btnDeleteCouple
            // 
            this.btnDeleteCouple.Location = new System.Drawing.Point(92, 366);
            this.btnDeleteCouple.Name = "btnDeleteCouple";
            this.btnDeleteCouple.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteCouple.TabIndex = 9;
            this.btnDeleteCouple.Text = "Ta bort par";
            this.btnDeleteCouple.UseVisualStyleBackColor = true;
            // 
            // CoupleChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteCouple);
            this.Name = "CoupleChart";
            this.Text = "CoupleAdd";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeletePlayerFromCouple;
        private System.Windows.Forms.Button btnDeleteCouple;
        private System.Windows.Forms.TextBox txtCoupleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPlayerInCouple;
        private System.Windows.Forms.ListBox lbCoupleChart;
        private System.Windows.Forms.Button btnCreateCouple;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnDeleteCoup;

    }
}