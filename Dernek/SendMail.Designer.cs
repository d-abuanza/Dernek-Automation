namespace Dernek
{
    partial class SendMail
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
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnMessageUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtMessage.Location = new System.Drawing.Point(111, 43);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(301, 258);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "";
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mesaj";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Location = new System.Drawing.Point(421, 270);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(147, 32);
            this.btnSendMail.TabIndex = 2;
            this.btnSendMail.Text = "Gönder";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnMessageUpdate
            // 
            this.btnMessageUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnMessageUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageUpdate.ForeColor = System.Drawing.Color.White;
            this.btnMessageUpdate.Location = new System.Drawing.Point(421, 43);
            this.btnMessageUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnMessageUpdate.Name = "btnMessageUpdate";
            this.btnMessageUpdate.Size = new System.Drawing.Size(147, 33);
            this.btnMessageUpdate.TabIndex = 3;
            this.btnMessageUpdate.Text = "Mesajı Düzenle";
            this.btnMessageUpdate.UseVisualStyleBackColor = false;
            this.btnMessageUpdate.Click += new System.EventHandler(this.btnMessageUpdate_Click);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(617, 353);
            this.Controls.Add(this.btnMessageUpdate);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendMail";
            this.Load += new System.EventHandler(this.SendMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnMessageUpdate;
    }
}