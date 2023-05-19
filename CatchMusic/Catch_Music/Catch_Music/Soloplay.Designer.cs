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
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtChatMsg = new System.Windows.Forms.TextBox();
            this.gameStartBtn = new System.Windows.Forms.Button();
            this.Nickname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.hintBtn1 = new System.Windows.Forms.Button();
            this.hintBtn2 = new System.Windows.Forms.Button();
            this.hintBtn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(12, 523);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(559, 21);
            this.txtMsg.TabIndex = 15;
            this.txtMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMsg_KeyPress);
            // 
            // txtChatMsg
            // 
            this.txtChatMsg.Location = new System.Drawing.Point(155, 66);
            this.txtChatMsg.Multiline = true;
            this.txtChatMsg.Name = "txtChatMsg";
            this.txtChatMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatMsg.Size = new System.Drawing.Size(416, 440);
            this.txtChatMsg.TabIndex = 14;
            // 
            // gameStartBtn
            // 
            this.gameStartBtn.Location = new System.Drawing.Point(41, 483);
            this.gameStartBtn.Name = "gameStartBtn";
            this.gameStartBtn.Size = new System.Drawing.Size(75, 23);
            this.gameStartBtn.TabIndex = 16;
            this.gameStartBtn.Text = "게임시작";
            this.gameStartBtn.UseVisualStyleBackColor = true;
            this.gameStartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nickname
            // 
            this.Nickname.AutoSize = true;
            this.Nickname.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nickname.Location = new System.Drawing.Point(456, 26);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(11, 12);
            this.Nickname.TabIndex = 17;
            this.Nickname.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(499, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
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
            this.hintBtn1.Location = new System.Drawing.Point(41, 119);
            this.hintBtn1.Name = "hintBtn1";
            this.hintBtn1.Size = new System.Drawing.Size(75, 23);
            this.hintBtn1.TabIndex = 20;
            this.hintBtn1.Text = "힌트1";
            this.hintBtn1.UseVisualStyleBackColor = true;
            this.hintBtn1.Click += new System.EventHandler(this.hintBtn1_Click);
            // 
            // hintBtn2
            // 
            this.hintBtn2.Location = new System.Drawing.Point(41, 166);
            this.hintBtn2.Name = "hintBtn2";
            this.hintBtn2.Size = new System.Drawing.Size(75, 23);
            this.hintBtn2.TabIndex = 21;
            this.hintBtn2.Text = "힌트2";
            this.hintBtn2.UseVisualStyleBackColor = true;
            this.hintBtn2.Click += new System.EventHandler(this.hintBtn2_Click);
            // 
            // hintBtn3
            // 
            this.hintBtn3.Location = new System.Drawing.Point(41, 213);
            this.hintBtn3.Name = "hintBtn3";
            this.hintBtn3.Size = new System.Drawing.Size(75, 23);
            this.hintBtn3.TabIndex = 22;
            this.hintBtn3.Text = "힌트3";
            this.hintBtn3.UseVisualStyleBackColor = true;
            this.hintBtn3.Click += new System.EventHandler(this.hintBtn3_Click);
            // 
            // Soloplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.hintBtn3);
            this.Controls.Add(this.hintBtn2);
            this.Controls.Add(this.hintBtn1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nickname);
            this.Controls.Add(this.gameStartBtn);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtChatMsg);
            this.Name = "Soloplay";
            this.Text = "Soloplay";
            this.Load += new System.EventHandler(this.Soloplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtChatMsg;
        private System.Windows.Forms.Button gameStartBtn;
        private System.Windows.Forms.Label Nickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button hintBtn1;
        private System.Windows.Forms.Button hintBtn2;
        private System.Windows.Forms.Button hintBtn3;
    }
}