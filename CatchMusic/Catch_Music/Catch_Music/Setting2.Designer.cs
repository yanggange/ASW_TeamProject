namespace Catch_Music
{
    partial class MySet2
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
            this.btnTeam = new System.Windows.Forms.Button();
            this.btnSolo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeam
            // 
            this.btnTeam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTeam.Location = new System.Drawing.Point(474, 175);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(150, 100);
            this.btnTeam.TabIndex = 1;
            this.btnTeam.Text = "멀티 플레이";
            this.btnTeam.UseVisualStyleBackColor = false;
            this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
            // 
            // btnSolo
            // 
            this.btnSolo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSolo.Location = new System.Drawing.Point(175, 175);
            this.btnSolo.Name = "btnSolo";
            this.btnSolo.Size = new System.Drawing.Size(150, 100);
            this.btnSolo.TabIndex = 2;
            this.btnSolo.Text = "솔로 플레이";
            this.btnSolo.UseVisualStyleBackColor = false;
            this.btnSolo.Click += new System.EventHandler(this.btnSolo_Click);
            // 
            // MySet2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSolo);
            this.Controls.Add(this.btnTeam);
            this.Name = "MySet2";
            this.Text = "MySet2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MySet2_FormClosed);
            this.Load += new System.EventHandler(this.MySet2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTeam;
        private System.Windows.Forms.Button btnSolo;
    }
}