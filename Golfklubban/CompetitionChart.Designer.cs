namespace Golfklubban
{
    partial class CompetitionChart
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
            this.Label16 = new System.Windows.Forms.Label();
            this.txtStopptid = new System.Windows.Forms.TextBox();
            this.btnSkapa_tävling = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtKlassC = new System.Windows.Forms.TextBox();
            this.txtKlassB = new System.Windows.Forms.TextBox();
            this.txtKlassA = new System.Windows.Forms.TextBox();
            this.txtAvbokningsdatum = new System.Windows.Forms.TextBox();
            this.txtAnmälningsdatum = new System.Windows.Forms.TextBox();
            this.txtStarttid = new System.Windows.Forms.TextBox();
            this.txtTävlingsnamn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(11, 98);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(46, 13);
            this.Label16.TabIndex = 329;
            this.Label16.Text = "Stopptid";
            // 
            // txtStopptid
            // 
            this.txtStopptid.Location = new System.Drawing.Point(12, 113);
            this.txtStopptid.Name = "txtStopptid";
            this.txtStopptid.Size = new System.Drawing.Size(146, 20);
            this.txtStopptid.TabIndex = 328;
            this.txtStopptid.TextChanged += new System.EventHandler(this.txtStopptid_TextChanged);
            // 
            // btnSkapa_tävling
            // 
            this.btnSkapa_tävling.Location = new System.Drawing.Point(12, 250);
            this.btnSkapa_tävling.Name = "btnSkapa_tävling";
            this.btnSkapa_tävling.Size = new System.Drawing.Size(103, 23);
            this.btnSkapa_tävling.TabIndex = 327;
            this.btnSkapa_tävling.Text = "Skapa tävling";
            this.btnSkapa_tävling.UseVisualStyleBackColor = true;
            this.btnSkapa_tävling.Click += new System.EventHandler(this.btnSkapa_tävling_Click);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(180, 84);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(71, 13);
            this.Label13.TabIndex = 326;
            this.Label13.Text = "Klass C gräns";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(180, 48);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(71, 13);
            this.Label12.TabIndex = 325;
            this.Label12.Text = "Klass B gräns";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(180, 7);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(71, 13);
            this.Label11.TabIndex = 324;
            this.Label11.Text = "Klass A gräns";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(9, 189);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(117, 13);
            this.Label10.TabIndex = 323;
            this.Label10.Text = "Sista avbokningsdatum";
            this.Label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(9, 142);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(115, 13);
            this.Label9.TabIndex = 322;
            this.Label9.Text = "Sista anmälningsdatum";
            this.Label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(9, 52);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(40, 13);
            this.Label8.TabIndex = 321;
            this.Label8.Text = "Starttid";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(9, 7);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(84, 13);
            this.Label7.TabIndex = 320;
            this.Label7.Text = "Namn på tävling";
            // 
            // txtKlassC
            // 
            this.txtKlassC.Location = new System.Drawing.Point(183, 99);
            this.txtKlassC.Name = "txtKlassC";
            this.txtKlassC.Size = new System.Drawing.Size(68, 20);
            this.txtKlassC.TabIndex = 319;
            // 
            // txtKlassB
            // 
            this.txtKlassB.Location = new System.Drawing.Point(183, 64);
            this.txtKlassB.Name = "txtKlassB";
            this.txtKlassB.Size = new System.Drawing.Size(68, 20);
            this.txtKlassB.TabIndex = 318;
            // 
            // txtKlassA
            // 
            this.txtKlassA.Location = new System.Drawing.Point(183, 23);
            this.txtKlassA.Name = "txtKlassA";
            this.txtKlassA.Size = new System.Drawing.Size(68, 20);
            this.txtKlassA.TabIndex = 317;
            // 
            // txtAvbokningsdatum
            // 
            this.txtAvbokningsdatum.Location = new System.Drawing.Point(12, 205);
            this.txtAvbokningsdatum.Name = "txtAvbokningsdatum";
            this.txtAvbokningsdatum.Size = new System.Drawing.Size(146, 20);
            this.txtAvbokningsdatum.TabIndex = 316;
            this.txtAvbokningsdatum.TextChanged += new System.EventHandler(this.txtAvbokningsdatum_TextChanged);
            // 
            // txtAnmälningsdatum
            // 
            this.txtAnmälningsdatum.Location = new System.Drawing.Point(12, 158);
            this.txtAnmälningsdatum.Name = "txtAnmälningsdatum";
            this.txtAnmälningsdatum.Size = new System.Drawing.Size(146, 20);
            this.txtAnmälningsdatum.TabIndex = 315;
            this.txtAnmälningsdatum.TextChanged += new System.EventHandler(this.txtAnmälningsdatum_TextChanged);
            // 
            // txtStarttid
            // 
            this.txtStarttid.Location = new System.Drawing.Point(12, 68);
            this.txtStarttid.Name = "txtStarttid";
            this.txtStarttid.Size = new System.Drawing.Size(146, 20);
            this.txtStarttid.TabIndex = 314;
            // 
            // txtTävlingsnamn
            // 
            this.txtTävlingsnamn.Location = new System.Drawing.Point(12, 23);
            this.txtTävlingsnamn.Name = "txtTävlingsnamn";
            this.txtTävlingsnamn.Size = new System.Drawing.Size(146, 20);
            this.txtTävlingsnamn.TabIndex = 313;
            // 
            // CompetitionChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 285);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.txtStopptid);
            this.Controls.Add(this.btnSkapa_tävling);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtKlassC);
            this.Controls.Add(this.txtKlassB);
            this.Controls.Add(this.txtKlassA);
            this.Controls.Add(this.txtAvbokningsdatum);
            this.Controls.Add(this.txtAnmälningsdatum);
            this.Controls.Add(this.txtStarttid);
            this.Controls.Add(this.txtTävlingsnamn);
            this.Name = "CompetitionChart";
            this.Text = "Tävlingar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtStopptid;
        internal System.Windows.Forms.Button btnSkapa_tävling;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtKlassC;
        internal System.Windows.Forms.TextBox txtKlassB;
        internal System.Windows.Forms.TextBox txtKlassA;
        internal System.Windows.Forms.TextBox txtAvbokningsdatum;
        internal System.Windows.Forms.TextBox txtAnmälningsdatum;
        internal System.Windows.Forms.TextBox txtStarttid;
        internal System.Windows.Forms.TextBox txtTävlingsnamn;
    }
}