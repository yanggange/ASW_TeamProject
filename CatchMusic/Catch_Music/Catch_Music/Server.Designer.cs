namespace Catch_Music
{
    partial class Server
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
            this.txtChatMsg = new System.Windows.Forms.TextBox();
            this.OnOffsv = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.IPtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.portNumTxt = new System.Windows.Forms.TextBox();
            this.musicAnswerP = new System.Windows.Forms.TextBox();
            this.answerTxt = new System.Windows.Forms.Label();
            this.hintBtn3 = new System.Windows.Forms.Button();
            this.hintBtn2 = new System.Windows.Forms.Button();
            this.hintBtn1 = new System.Windows.Forms.Button();
            this.musicTitleMsg = new System.Windows.Forms.TextBox();
            this.musicStartBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChatMsg
            // 
            this.txtChatMsg.Location = new System.Drawing.Point(13, 13);
            this.txtChatMsg.Multiline = true;
            this.txtChatMsg.Name = "txtChatMsg";
            this.txtChatMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatMsg.Size = new System.Drawing.Size(559, 245);
            this.txtChatMsg.TabIndex = 0;
            // 
            // OnOffsv
            // 
            this.OnOffsv.AutoSize = true;
            this.OnOffsv.Location = new System.Drawing.Point(139, 278);
            this.OnOffsv.Name = "OnOffsv";
            this.OnOffsv.Size = new System.Drawing.Size(29, 12);
            this.OnOffsv.TabIndex = 1;
            this.OnOffsv.Tag = "Stop";
            this.OnOffsv.Text = "닫힘";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(310, 278);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(262, 84);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "방 열기";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // IPtxt
            // 
            this.IPtxt.AutoSize = true;
            this.IPtxt.Location = new System.Drawing.Point(129, 305);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(16, 12);
            this.IPtxt.TabIndex = 17;
            this.IPtxt.Text = "IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "방번호";
            // 
            // portNumTxt
            // 
            this.portNumTxt.Location = new System.Drawing.Point(152, 332);
            this.portNumTxt.Name = "portNumTxt";
            this.portNumTxt.Size = new System.Drawing.Size(100, 21);
            this.portNumTxt.TabIndex = 15;
            // 
            // musicAnswerP
            // 
            this.musicAnswerP.Enabled = false;
            this.musicAnswerP.Location = new System.Drawing.Point(267, 515);
            this.musicAnswerP.Name = "musicAnswerP";
            this.musicAnswerP.Size = new System.Drawing.Size(100, 21);
            this.musicAnswerP.TabIndex = 24;
            this.musicAnswerP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.musicAnswerP_KeyDown);
            // 
            // answerTxt
            // 
            this.answerTxt.AutoSize = true;
            this.answerTxt.Enabled = false;
            this.answerTxt.Location = new System.Drawing.Point(220, 518);
            this.answerTxt.Name = "answerTxt";
            this.answerTxt.Size = new System.Drawing.Size(41, 12);
            this.answerTxt.TabIndex = 23;
            this.answerTxt.Text = "정답자";
            // 
            // hintBtn3
            // 
            this.hintBtn3.Enabled = false;
            this.hintBtn3.Location = new System.Drawing.Point(448, 440);
            this.hintBtn3.Name = "hintBtn3";
            this.hintBtn3.Size = new System.Drawing.Size(75, 23);
            this.hintBtn3.TabIndex = 22;
            this.hintBtn3.Text = "힌트3";
            this.hintBtn3.UseVisualStyleBackColor = true;
            this.hintBtn3.Click += new System.EventHandler(this.hintBtn3_Click);
            // 
            // hintBtn2
            // 
            this.hintBtn2.Enabled = false;
            this.hintBtn2.Location = new System.Drawing.Point(367, 440);
            this.hintBtn2.Name = "hintBtn2";
            this.hintBtn2.Size = new System.Drawing.Size(75, 23);
            this.hintBtn2.TabIndex = 21;
            this.hintBtn2.Text = "힌트2";
            this.hintBtn2.UseVisualStyleBackColor = true;
            this.hintBtn2.Click += new System.EventHandler(this.hintBtn2_Click);
            // 
            // hintBtn1
            // 
            this.hintBtn1.Enabled = false;
            this.hintBtn1.Location = new System.Drawing.Point(286, 440);
            this.hintBtn1.Name = "hintBtn1";
            this.hintBtn1.Size = new System.Drawing.Size(75, 23);
            this.hintBtn1.TabIndex = 20;
            this.hintBtn1.Text = "힌트1";
            this.hintBtn1.UseVisualStyleBackColor = true;
            this.hintBtn1.Click += new System.EventHandler(this.hintBtn1_Click);
            // 
            // musicTitleMsg
            // 
            this.musicTitleMsg.Enabled = false;
            this.musicTitleMsg.Location = new System.Drawing.Point(83, 396);
            this.musicTitleMsg.Name = "musicTitleMsg";
            this.musicTitleMsg.Size = new System.Drawing.Size(489, 21);
            this.musicTitleMsg.TabIndex = 19;
            // 
            // musicStartBtn
            // 
            this.musicStartBtn.Enabled = false;
            this.musicStartBtn.Location = new System.Drawing.Point(83, 423);
            this.musicStartBtn.Name = "musicStartBtn";
            this.musicStartBtn.Size = new System.Drawing.Size(158, 57);
            this.musicStartBtn.TabIndex = 18;
            this.musicStartBtn.Text = "노래실행";
            this.musicStartBtn.UseVisualStyleBackColor = true;
            this.musicStartBtn.Click += new System.EventHandler(this.musicStartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "실행할 노래";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.musicAnswerP);
            this.Controls.Add(this.answerTxt);
            this.Controls.Add(this.hintBtn3);
            this.Controls.Add(this.hintBtn2);
            this.Controls.Add(this.hintBtn1);
            this.Controls.Add(this.musicTitleMsg);
            this.Controls.Add(this.musicStartBtn);
            this.Controls.Add(this.IPtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portNumTxt);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.OnOffsv);
            this.Controls.Add(this.txtChatMsg);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChatMsg;
        private System.Windows.Forms.Label OnOffsv;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label IPtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portNumTxt;
        private System.Windows.Forms.TextBox musicAnswerP;
        private System.Windows.Forms.Label answerTxt;
        private System.Windows.Forms.Button hintBtn3;
        private System.Windows.Forms.Button hintBtn2;
        private System.Windows.Forms.Button hintBtn1;
        private System.Windows.Forms.TextBox musicTitleMsg;
        private System.Windows.Forms.Button musicStartBtn;
        private System.Windows.Forms.Label label2;
    }
}