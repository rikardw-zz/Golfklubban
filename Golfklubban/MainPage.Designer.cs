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
            this.lagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaMedlemmarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillMedlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaLagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillLagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaKommandeTävlingarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaAvslutadeTävlingarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillNyTävlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stängToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
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
            this.visaMedlemmarToolStripMenuItem,
            this.läggTillMedlemToolStripMenuItem});
            this.medlemmarToolStripMenuItem.Name = "medlemmarToolStripMenuItem";
            this.medlemmarToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.medlemmarToolStripMenuItem.Text = "Medlemmar";
            // 
            // lagToolStripMenuItem
            // 
            this.lagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visaLagToolStripMenuItem,
            this.läggTillLagToolStripMenuItem});
            this.lagToolStripMenuItem.Name = "lagToolStripMenuItem";
            this.lagToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.lagToolStripMenuItem.Text = "Lag";
            // 
            // tävlingarToolStripMenuItem
            // 
            this.tävlingarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visaKommandeTävlingarToolStripMenuItem,
            this.visaAvslutadeTävlingarToolStripMenuItem,
            this.läggTillNyTävlingToolStripMenuItem});
            this.tävlingarToolStripMenuItem.Name = "tävlingarToolStripMenuItem";
            this.tävlingarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tävlingarToolStripMenuItem.Text = "Tävlingar";
            // 
            // visaMedlemmarToolStripMenuItem
            // 
            this.visaMedlemmarToolStripMenuItem.Name = "visaMedlemmarToolStripMenuItem";
            this.visaMedlemmarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.visaMedlemmarToolStripMenuItem.Text = "Visa medlemmar";
            this.visaMedlemmarToolStripMenuItem.Click += new System.EventHandler(this.visaMedlemmarToolStripMenuItem_Click);
            // 
            // läggTillMedlemToolStripMenuItem
            // 
            this.läggTillMedlemToolStripMenuItem.Name = "läggTillMedlemToolStripMenuItem";
            this.läggTillMedlemToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.läggTillMedlemToolStripMenuItem.Text = "Lägg till ny medlem";
            this.läggTillMedlemToolStripMenuItem.Click += new System.EventHandler(this.läggTillMedlemToolStripMenuItem_Click);
            // 
            // visaLagToolStripMenuItem
            // 
            this.visaLagToolStripMenuItem.Name = "visaLagToolStripMenuItem";
            this.visaLagToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.visaLagToolStripMenuItem.Text = "Visa lag";
            // 
            // läggTillLagToolStripMenuItem
            // 
            this.läggTillLagToolStripMenuItem.Name = "läggTillLagToolStripMenuItem";
            this.läggTillLagToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.läggTillLagToolStripMenuItem.Text = "Lägg till nytt lag";
            // 
            // visaKommandeTävlingarToolStripMenuItem
            // 
            this.visaKommandeTävlingarToolStripMenuItem.Name = "visaKommandeTävlingarToolStripMenuItem";
            this.visaKommandeTävlingarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.visaKommandeTävlingarToolStripMenuItem.Text = "Visa kommande tävlingar";
            // 
            // visaAvslutadeTävlingarToolStripMenuItem
            // 
            this.visaAvslutadeTävlingarToolStripMenuItem.Name = "visaAvslutadeTävlingarToolStripMenuItem";
            this.visaAvslutadeTävlingarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.visaAvslutadeTävlingarToolStripMenuItem.Text = "Visa avslutade tävlingar(?)";
            // 
            // läggTillNyTävlingToolStripMenuItem
            // 
            this.läggTillNyTävlingToolStripMenuItem.Name = "läggTillNyTävlingToolStripMenuItem";
            this.läggTillNyTävlingToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.läggTillNyTävlingToolStripMenuItem.Text = "Lägg till ny tävling";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(755, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "(Bokningar)";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 523);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ToolStripMenuItem visaAvslutadeTävlingarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillNyTävlingToolStripMenuItem;
        private System.Windows.Forms.Label label1;


    }
}

