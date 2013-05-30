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
            this.stängToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medlemmarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaMedlemmarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillMedlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaLagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillLagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaKommandeTävlingarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillNyTävlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.taBortMedlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortMedlemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.taBortTävlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.medlemmarToolStripMenuItem,
            this.lagToolStripMenuItem,
            this.tävlingarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
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
            // stängToolStripMenuItem
            // 
            this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
            this.stängToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.stängToolStripMenuItem.Text = "Stäng";
            this.stängToolStripMenuItem.Click += new System.EventHandler(this.stängToolStripMenuItem_Click);
            // 
            // medlemmarToolStripMenuItem
            // 
            this.medlemmarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visaMedlemmarToolStripMenuItem,
            this.läggTillMedlemToolStripMenuItem,
            this.taBortMedlemToolStripMenuItem});
            this.medlemmarToolStripMenuItem.Name = "medlemmarToolStripMenuItem";
            this.medlemmarToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.medlemmarToolStripMenuItem.Text = "Medlemmar";
            // 
            // visaMedlemmarToolStripMenuItem
            // 
            this.visaMedlemmarToolStripMenuItem.Name = "visaMedlemmarToolStripMenuItem";
            this.visaMedlemmarToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.visaMedlemmarToolStripMenuItem.Text = "Visa/Ändra medlemmsinfo";
            this.visaMedlemmarToolStripMenuItem.Click += new System.EventHandler(this.visaMedlemmarToolStripMenuItem_Click);
            // 
            // läggTillMedlemToolStripMenuItem
            // 
            this.läggTillMedlemToolStripMenuItem.Name = "läggTillMedlemToolStripMenuItem";
            this.läggTillMedlemToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.läggTillMedlemToolStripMenuItem.Text = "Lägg till ny medlem";
            this.läggTillMedlemToolStripMenuItem.Click += new System.EventHandler(this.läggTillMedlemToolStripMenuItem_Click);
            // 
            // lagToolStripMenuItem
            // 
            this.lagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visaLagToolStripMenuItem,
            this.läggTillLagToolStripMenuItem,
            this.taBortMedlemToolStripMenuItem1});
            this.lagToolStripMenuItem.Name = "lagToolStripMenuItem";
            this.lagToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.lagToolStripMenuItem.Text = "Lag";
            // 
            // visaLagToolStripMenuItem
            // 
            this.visaLagToolStripMenuItem.Name = "visaLagToolStripMenuItem";
            this.visaLagToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.visaLagToolStripMenuItem.Text = "Visa lag";
            this.visaLagToolStripMenuItem.Click += new System.EventHandler(this.visaLagToolStripMenuItem_Click);
            // 
            // läggTillLagToolStripMenuItem
            // 
            this.läggTillLagToolStripMenuItem.Name = "läggTillLagToolStripMenuItem";
            this.läggTillLagToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.läggTillLagToolStripMenuItem.Text = "Lägg till nytt lag";
            // 
            // tävlingarToolStripMenuItem
            // 
            this.tävlingarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visaKommandeTävlingarToolStripMenuItem,
            this.läggTillNyTävlingToolStripMenuItem,
            this.taBortTävlingToolStripMenuItem});
            this.tävlingarToolStripMenuItem.Name = "tävlingarToolStripMenuItem";
            this.tävlingarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tävlingarToolStripMenuItem.Text = "Tävling";
            // 
            // visaKommandeTävlingarToolStripMenuItem
            // 
            this.visaKommandeTävlingarToolStripMenuItem.Name = "visaKommandeTävlingarToolStripMenuItem";
            this.visaKommandeTävlingarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.visaKommandeTävlingarToolStripMenuItem.Text = "Visa kommande tävlingar";
            // 
            // läggTillNyTävlingToolStripMenuItem
            // 
            this.läggTillNyTävlingToolStripMenuItem.Name = "läggTillNyTävlingToolStripMenuItem";
            this.läggTillNyTävlingToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.läggTillNyTävlingToolStripMenuItem.Text = "Lägg till ny tävling";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 316);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(292, 55);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(148, 316);
            this.listBox2.TabIndex = 2;
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
            this.button1.Location = new System.Drawing.Point(337, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Genomför bokning";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // taBortMedlemToolStripMenuItem
            // 
            this.taBortMedlemToolStripMenuItem.Name = "taBortMedlemToolStripMenuItem";
            this.taBortMedlemToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.taBortMedlemToolStripMenuItem.Text = "Ta bort medlem";
            // 
            // taBortMedlemToolStripMenuItem1
            // 
            this.taBortMedlemToolStripMenuItem1.Name = "taBortMedlemToolStripMenuItem1";
            this.taBortMedlemToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.taBortMedlemToolStripMenuItem1.Text = "Ta bort medlem";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(514, 55);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(148, 316);
            this.listBox3.TabIndex = 2;
            // 
            // taBortTävlingToolStripMenuItem
            // 
            this.taBortTävlingToolStripMenuItem.Name = "taBortTävlingToolStripMenuItem";
            this.taBortTävlingToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.taBortTävlingToolStripMenuItem.Text = "Ta bort tävling";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ToolStripMenuItem visaMedlemmarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillMedlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaLagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillLagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaKommandeTävlingarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillNyTävlingToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem taBortMedlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortMedlemToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortTävlingToolStripMenuItem;


    }
}

