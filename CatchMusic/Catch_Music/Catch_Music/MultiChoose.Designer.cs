namespace Catch_Music
{
    partial class MultiChoose
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiChoose));
            this.makeBtn = new System.Windows.Forms.Button();
            this.multiBtn = new System.Windows.Forms.Button();
            this.txtNick = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // makeBtn
            // 
            this.makeBtn.BackColor = System.Drawing.SystemColors.Info;
            this.makeBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.makeBtn.Location = new System.Drawing.Point(26, 25);
            this.makeBtn.Name = "makeBtn";
            this.makeBtn.Size = new System.Drawing.Size(152, 84);
            this.makeBtn.TabIndex = 1;
            this.makeBtn.Text = "방만들기";
            this.makeBtn.UseVisualStyleBackColor = false;
            this.makeBtn.Click += new System.EventHandler(this.makeBtn_Click);
            // 
            // multiBtn
            // 
            this.multiBtn.BackColor = System.Drawing.SystemColors.Info;
            this.multiBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.multiBtn.Location = new System.Drawing.Point(201, 25);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.Size = new System.Drawing.Size(152, 84);
            this.multiBtn.TabIndex = 2;
            this.multiBtn.Text = "참가";
            this.multiBtn.UseVisualStyleBackColor = false;
            this.multiBtn.Click += new System.EventHandler(this.multiBtn_Click);
            // 
            // txtNick
            // 
            this.txtNick.Font = new System.Drawing.Font("굴림", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNick.Location = new System.Drawing.Point(141, 4);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(212, 18);
            this.txtNick.TabIndex = 3;
            this.txtNick.Text = "unknown";
            this.txtNick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-20, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MultiChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.multiBtn);
            this.Controls.Add(this.makeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiChoose";
            this.Text = "Choose";
            this.Load += new System.EventHandler(this.MultiChoose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button makeBtn;
        private System.Windows.Forms.Button multiBtn;
        private System.Windows.Forms.Label txtNick;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

