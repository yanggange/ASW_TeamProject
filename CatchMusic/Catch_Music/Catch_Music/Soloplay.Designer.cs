namespace Catch_Music
{
    partial class Soloplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Soloplay));
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtChatMsg = new System.Windows.Forms.TextBox();
            this.gameStartBtn = new System.Windows.Forms.Button();
            this.Nickname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.hintBtn1 = new System.Windows.Forms.Button();
            this.hintBtn2 = new System.Windows.Forms.Button();
            this.hintBtn3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.easyBtn = new System.Windows.Forms.RadioButton();
            this.nomalBtn = new System.Windows.Forms.RadioButton();
            this.hignBtn = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addsong = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(12, 523);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(559, 21);
            this.txtMsg.TabIndex = 5;
            this.txtMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMsg_KeyPress);
            // 
            // txtChatMsg
            // 
            this.txtChatMsg.Location = new System.Drawing.Point(155, 66);
            this.txtChatMsg.Multiline = true;
            this.txtChatMsg.Name = "txtChatMsg";
            this.txtChatMsg.ReadOnly = true;
            this.txtChatMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatMsg.Size = new System.Drawing.Size(416, 440);
            this.txtChatMsg.TabIndex = 14;
            // 
            // gameStartBtn
            // 
            this.gameStartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gameStartBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gameStartBtn.Location = new System.Drawing.Point(41, 483);
            this.gameStartBtn.Name = "gameStartBtn";
            this.gameStartBtn.Size = new System.Drawing.Size(75, 23);
            this.gameStartBtn.TabIndex = 4;
            this.gameStartBtn.Text = "게임시작";
            this.gameStartBtn.UseVisualStyleBackColor = false;
            this.gameStartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nickname
            // 
            this.Nickname.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Nickname.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nickname.Location = new System.Drawing.Point(165, 26);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(302, 12);
            this.Nickname.TabIndex = 17;
            this.Nickname.Text = "name";
            this.Nickname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(499, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "Score";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Score.Location = new System.Drawing.Point(543, 26);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(11, 12);
            this.Score.TabIndex = 19;
            this.Score.Text = "0";
            // 
            // hintBtn1
            // 
            this.hintBtn1.BackColor = System.Drawing.SystemColors.Info;
            this.hintBtn1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hintBtn1.Location = new System.Drawing.Point(41, 119);
            this.hintBtn1.Name = "hintBtn1";
            this.hintBtn1.Size = new System.Drawing.Size(75, 23);
            this.hintBtn1.TabIndex = 0;
            this.hintBtn1.Text = "힌트1";
            this.hintBtn1.UseVisualStyleBackColor = false;
            this.hintBtn1.Click += new System.EventHandler(this.hintBtn1_Click);
            // 
            // hintBtn2
            // 
            this.hintBtn2.BackColor = System.Drawing.SystemColors.Info;
            this.hintBtn2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hintBtn2.Location = new System.Drawing.Point(41, 166);
            this.hintBtn2.Name = "hintBtn2";
            this.hintBtn2.Size = new System.Drawing.Size(75, 23);
            this.hintBtn2.TabIndex = 1;
            this.hintBtn2.Text = "힌트2";
            this.hintBtn2.UseVisualStyleBackColor = false;
            this.hintBtn2.Click += new System.EventHandler(this.hintBtn2_Click);
            // 
            // hintBtn3
            // 
            this.hintBtn3.BackColor = System.Drawing.SystemColors.Info;
            this.hintBtn3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hintBtn3.Location = new System.Drawing.Point(41, 213);
            this.hintBtn3.Name = "hintBtn3";
            this.hintBtn3.Size = new System.Drawing.Size(75, 23);
            this.hintBtn3.TabIndex = 2;
            this.hintBtn3.Text = "힌트3";
            this.hintBtn3.UseVisualStyleBackColor = false;
            this.hintBtn3.Click += new System.EventHandler(this.hintBtn3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.easyBtn);
            this.groupBox1.Controls.Add(this.nomalBtn);
            this.groupBox1.Controls.Add(this.hignBtn);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 161);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "시간선택";
            // 
            // easyBtn
            // 
            this.easyBtn.AutoSize = true;
            this.easyBtn.Location = new System.Drawing.Point(12, 123);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(88, 16);
            this.easyBtn.TabIndex = 2;
            this.easyBtn.TabStop = true;
            this.easyBtn.Text = "쉬움(15초)";
            this.easyBtn.UseVisualStyleBackColor = true;
            this.easyBtn.CheckedChanged += new System.EventHandler(this.easyBtn_CheckedChanged);
            // 
            // nomalBtn
            // 
            this.nomalBtn.AutoSize = true;
            this.nomalBtn.Location = new System.Drawing.Point(12, 75);
            this.nomalBtn.Name = "nomalBtn";
            this.nomalBtn.Size = new System.Drawing.Size(88, 16);
            this.nomalBtn.TabIndex = 1;
            this.nomalBtn.TabStop = true;
            this.nomalBtn.Text = "보통(10초)";
            this.nomalBtn.UseVisualStyleBackColor = true;
            this.nomalBtn.CheckedChanged += new System.EventHandler(this.nomalBtn_CheckedChanged);
            // 
            // hignBtn
            // 
            this.hignBtn.AutoSize = true;
            this.hignBtn.Location = new System.Drawing.Point(12, 30);
            this.hignBtn.Name = "hignBtn";
            this.hignBtn.Size = new System.Drawing.Size(94, 16);
            this.hignBtn.TabIndex = 0;
            this.hignBtn.TabStop = true;
            this.hignBtn.Text = "어려움(5초)";
            this.hignBtn.UseVisualStyleBackColor = true;
            this.hignBtn.CheckedChanged += new System.EventHandler(this.hignBtn_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // addsong
            // 
            this.addsong.BackColor = System.Drawing.SystemColors.Info;
            this.addsong.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addsong.Location = new System.Drawing.Point(41, 265);
            this.addsong.Name = "addsong";
            this.addsong.Size = new System.Drawing.Size(75, 23);
            this.addsong.TabIndex = 3;
            this.addsong.Text = "노래 추가";
            this.addsong.UseVisualStyleBackColor = false;
            this.addsong.Click += new System.EventHandler(this.addsong_Click);
            // 
            // btnPass
            // 
            this.btnPass.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPass.Location = new System.Drawing.Point(41, 78);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(75, 23);
            this.btnPass.TabIndex = 26;
            this.btnPass.Text = "PASS";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // Soloplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.addsong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hintBtn3);
            this.Controls.Add(this.hintBtn2);
            this.Controls.Add(this.hintBtn1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nickname);
            this.Controls.Add(this.gameStartBtn);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtChatMsg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Soloplay";
            this.Text = "Soloplay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Soloplay_FormClosed);
            this.Load += new System.EventHandler(this.Soloplay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button gameStartBtn;
        private System.Windows.Forms.Label Nickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button hintBtn1;
        private System.Windows.Forms.Button hintBtn2;
        private System.Windows.Forms.Button hintBtn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton easyBtn;
        private System.Windows.Forms.RadioButton nomalBtn;
        private System.Windows.Forms.RadioButton hignBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addsong;
        private System.Windows.Forms.TextBox txtChatMsg;
        private System.Windows.Forms.Button btnPass;
    }
}