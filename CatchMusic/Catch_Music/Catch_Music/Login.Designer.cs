﻿namespace Catch_Music
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.labellogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Font = new System.Drawing.Font("굴림", 12F);
            this.txtID.Location = new System.Drawing.Point(75, 95);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 26);
            this.txtID.TabIndex = 1;
            // 
            // txtPW
            // 
            this.txtPW.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPW.Font = new System.Drawing.Font("굴림", 12F);
            this.txtPW.Location = new System.Drawing.Point(75, 160);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(250, 26);
            this.txtPW.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogin.Font = new System.Drawing.Font("굴림", 12F);
            this.btnLogin.Location = new System.Drawing.Point(75, 219);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "로 그 인";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.SystemColors.Info;
            this.btnSign.Font = new System.Drawing.Font("굴림", 12F);
            this.btnSign.Location = new System.Drawing.Point(205, 219);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(120, 30);
            this.btnSign.TabIndex = 4;
            this.btnSign.Text = "회원가입";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labellogin.Location = new System.Drawing.Point(150, 30);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(96, 27);
            this.labellogin.TabIndex = 4;
            this.labellogin.Text = "로그인";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(384, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}