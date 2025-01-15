namespace Dernek
{
    partial class MemberPage
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
            this.lblSayHello = new System.Windows.Forms.Label();
            this.txtDuesAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepthAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnMemberPayments = new System.Windows.Forms.Button();
            this.btnDuesSet = new System.Windows.Forms.Button();
            this.btnDepthSet = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxBloodType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayHello
            // 
            this.lblSayHello.AutoSize = true;
            this.lblSayHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayHello.Location = new System.Drawing.Point(16, 11);
            this.lblSayHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSayHello.Name = "lblSayHello";
            this.lblSayHello.Size = new System.Drawing.Size(0, 20);
            this.lblSayHello.TabIndex = 0;
            // 
            // txtDuesAmount
            // 
            this.txtDuesAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuesAmount.Location = new System.Drawing.Point(220, 345);
            this.txtDuesAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuesAmount.Name = "txtDuesAmount";
            this.txtDuesAmount.ReadOnly = true;
            this.txtDuesAmount.Size = new System.Drawing.Size(173, 26);
            this.txtDuesAmount.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 85;
            this.label8.Text = "Aidat: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 378);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 20);
            this.label7.TabIndex = 84;
            this.label7.Text = "Aidat Son Ödeme Tarihi: ";
            // 
            // txtDepthAmount
            // 
            this.txtDepthAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepthAmount.Location = new System.Drawing.Point(220, 318);
            this.txtDepthAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepthAmount.Name = "txtDepthAmount";
            this.txtDepthAmount.ReadOnly = true;
            this.txtDepthAmount.Size = new System.Drawing.Size(173, 26);
            this.txtDepthAmount.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 82;
            this.label6.Text = "Borç: ";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Location = new System.Drawing.Point(219, 374);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(174, 26);
            this.dtpDueDate.TabIndex = 89;
            // 
            // btnMemberPayments
            // 
            this.btnMemberPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnMemberPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberPayments.ForeColor = System.Drawing.Color.White;
            this.btnMemberPayments.Location = new System.Drawing.Point(400, 372);
            this.btnMemberPayments.Name = "btnMemberPayments";
            this.btnMemberPayments.Size = new System.Drawing.Size(99, 51);
            this.btnMemberPayments.TabIndex = 90;
            this.btnMemberPayments.Text = "Geçmiş Ödemeler";
            this.btnMemberPayments.UseVisualStyleBackColor = false;
            this.btnMemberPayments.Click += new System.EventHandler(this.btnMemberPayments_Click);
            // 
            // btnDuesSet
            // 
            this.btnDuesSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnDuesSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuesSet.ForeColor = System.Drawing.Color.White;
            this.btnDuesSet.Location = new System.Drawing.Point(400, 344);
            this.btnDuesSet.Name = "btnDuesSet";
            this.btnDuesSet.Size = new System.Drawing.Size(99, 23);
            this.btnDuesSet.TabIndex = 88;
            this.btnDuesSet.Text = "Aidat Öde";
            this.btnDuesSet.UseVisualStyleBackColor = false;
            this.btnDuesSet.Click += new System.EventHandler(this.btnDuesSet_Click);
            // 
            // btnDepthSet
            // 
            this.btnDepthSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnDepthSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepthSet.ForeColor = System.Drawing.Color.White;
            this.btnDepthSet.Location = new System.Drawing.Point(400, 317);
            this.btnDepthSet.Name = "btnDepthSet";
            this.btnDepthSet.Size = new System.Drawing.Size(99, 23);
            this.btnDepthSet.TabIndex = 87;
            this.btnDepthSet.Text = "Borç Öde";
            this.btnDepthSet.UseVisualStyleBackColor = false;
            this.btnDepthSet.Click += new System.EventHandler(this.btnDepthSet_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPassword.Location = new System.Drawing.Point(221, 165);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 26);
            this.txtPassword.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 171);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 80;
            this.label11.Text = "Şifre: ";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMail.Location = new System.Drawing.Point(221, 135);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(173, 26);
            this.txtMail.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 78;
            this.label10.Text = "Eposta: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(400, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 36);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Şehir: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Kan Grubu: ";
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(221, 224);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(173, 28);
            this.cbxCity.TabIndex = 71;
            // 
            // cbxBloodType
            // 
            this.cbxBloodType.FormattingEnabled = true;
            this.cbxBloodType.Location = new System.Drawing.Point(221, 194);
            this.cbxBloodType.Name = "cbxBloodType";
            this.cbxBloodType.Size = new System.Drawing.Size(173, 28);
            this.cbxBloodType.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "TcKimlik: ";
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTcKimlik.Location = new System.Drawing.Point(221, 45);
            this.txtTcKimlik.Margin = new System.Windows.Forms.Padding(4);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.ReadOnly = true;
            this.txtTcKimlik.Size = new System.Drawing.Size(173, 26);
            this.txtTcKimlik.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "İsim: ";
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.White;
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtLastname.Location = new System.Drawing.Point(221, 105);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(173, 26);
            this.txtLastname.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Soyisim: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtFirstName.Location = new System.Drawing.Point(221, 75);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(173, 26);
            this.txtFirstName.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(280, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 31);
            this.label9.TabIndex = 91;
            this.label9.Text = "Dernek Üye Sayfası";
            // 
            // MemberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 446);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDuesAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDepthAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnMemberPayments);
            this.Controls.Add(this.btnDuesSet);
            this.Controls.Add(this.btnDepthSet);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.cbxBloodType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblSayHello);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemberPage_FormClosing);
            this.Load += new System.EventHandler(this.MemberPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayHello;
        private System.Windows.Forms.TextBox txtDuesAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepthAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnMemberPayments;
        private System.Windows.Forms.Button btnDuesSet;
        private System.Windows.Forms.Button btnDepthSet;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxBloodType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label9;
    }
}