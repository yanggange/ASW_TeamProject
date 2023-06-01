using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_Music
{
    public partial class MySet2 : Form
    {
        public MySet2()
        {
            InitializeComponent();
        }
        public string PassNick
        { get; set; }
        private void btnTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiChoose multiChoose = new MultiChoose();
            multiChoose.PassNick = txtNick.Text;
            multiChoose.ShowDialog();
            this.Show();
        }

        private void btnSolo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Soloplay solo = new Soloplay();
            solo.PassNick = txtNick.Text;
            solo.ShowDialog();
            this.Show();
        }

        private void MySet2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MySet2_Load(object sender, EventArgs e)
        {
            txtNick.Text = PassNick;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
