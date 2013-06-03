namespace Golfklubban
{
    partial class PlayerChart
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
            this.label22 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Förnamn = new System.Windows.Forms.Label();
            this.txtHandicap = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPersonnr = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMembershipStatus = new System.Windows.Forms.ComboBox();
            this.cbMembershipFee = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 161);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 352;
            this.label22.Text = "Postnummer";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(12, 177);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtZipCode.TabIndex = 332;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(151, 161);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 351;
            this.label21.Text = "Gatunummer";
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(154, 177);
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStreetNumber.TabIndex = 331;
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(364, 323);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(100, 23);
            this.btnDeletePlayer.TabIndex = 350;
            this.btnDeletePlayer.Text = "Ta bort spelare";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 336);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 23);
            this.btnRegister.TabIndex = 341;
            this.btnRegister.Text = "Registrera";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 213);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(53, 13);
            this.Label6.TabIndex = 348;
            this.Label6.Text = "Handicap";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(151, 211);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(32, 13);
            this.Label5.TabIndex = 347;
            this.Label5.Text = "Email";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(151, 118);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 13);
            this.Label4.TabIndex = 346;
            this.Label4.Text = "Mobil";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 118);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(61, 13);
            this.Label3.TabIndex = 345;
            this.Label3.Text = "Gatuadress";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(134, 13);
            this.Label2.TabIndex = 344;
            this.Label2.Text = "Personnummer (YYMMDD)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(151, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 13);
            this.Label1.TabIndex = 343;
            this.Label1.Text = "Efternamn";
            // 
            // Förnamn
            // 
            this.Förnamn.AutoSize = true;
            this.Förnamn.Location = new System.Drawing.Point(9, 11);
            this.Förnamn.Name = "Förnamn";
            this.Förnamn.Size = new System.Drawing.Size(48, 13);
            this.Förnamn.TabIndex = 342;
            this.Förnamn.Text = "Förnamn";
            // 
            // txtHandicap
            // 
            this.txtHandicap.Location = new System.Drawing.Point(12, 229);
            this.txtHandicap.Name = "txtHandicap";
            this.txtHandicap.Size = new System.Drawing.Size(100, 20);
            this.txtHandicap.TabIndex = 334;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 333;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(154, 134);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(100, 20);
            this.txtMobilePhone.TabIndex = 329;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 134);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 330;
            // 
            // txtPersonnr
            // 
            this.txtPersonnr.Location = new System.Drawing.Point(12, 81);
            this.txtPersonnr.Name = "txtPersonnr";
            this.txtPersonnr.Size = new System.Drawing.Size(100, 20);
            this.txtPersonnr.TabIndex = 328;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(154, 27);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 327;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 326;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Man",
            "Kvinna"});
            this.cbSex.Location = new System.Drawing.Point(154, 80);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(100, 21);
            this.cbSex.TabIndex = 355;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 344;
            this.label7.Text = "Kön";
            // 
            // cbMembershipStatus
            // 
            this.cbMembershipStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembershipStatus.FormattingEnabled = true;
            this.cbMembershipStatus.Items.AddRange(new object[] {
            "Aktiv",
            "Vilande",
            "Junior",
            "Greenfee",
            "Gäst"});
            this.cbMembershipStatus.Location = new System.Drawing.Point(12, 284);
            this.cbMembershipStatus.Name = "cbMembershipStatus";
            this.cbMembershipStatus.Size = new System.Drawing.Size(100, 21);
            this.cbMembershipStatus.TabIndex = 355;
            // 
            // cbMembershipFee
            // 
            this.cbMembershipFee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembershipFee.FormattingEnabled = true;
            this.cbMembershipFee.Items.AddRange(new object[] {
            "Betald",
            "Ej betald"});
            this.cbMembershipFee.Location = new System.Drawing.Point(154, 284);
            this.cbMembershipFee.Name = "cbMembershipFee";
            this.cbMembershipFee.Size = new System.Drawing.Size(100, 21);
            this.cbMembershipFee.TabIndex = 355;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 347;
            this.label8.Text = "Avgift";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 347;
            this.label9.Text = "Status";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(287, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 277);
            this.listBox1.TabIndex = 356;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 341;
            this.btnUpdate.Text = "Uppdatera";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // PlayerChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 394);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbMembershipFee);
            this.Controls.Add(this.cbMembershipStatus);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtStreetNumber);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Förnamn);
            this.Controls.Add(this.txtHandicap);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobilePhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPersonnr);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "PlayerChart";
            this.Text = "Hantera Spelare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.TextBox txtZipCode;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.TextBox txtStreetNumber;
        internal System.Windows.Forms.Button btnDeletePlayer;
        internal System.Windows.Forms.Button btnRegister;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Förnamn;
        internal System.Windows.Forms.TextBox txtHandicap;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtMobilePhone;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtPersonnr;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cbSex;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMembershipStatus;
        private System.Windows.Forms.ComboBox cbMembershipFee;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        internal System.Windows.Forms.Button btnUpdate;
    }
}