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
    public partial class MySet3 : Form
    {
        public string PassNick
        { get; set; }
        public MySet3()
        {
            InitializeComponent();
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiChoose multiChoose = new MultiChoose();
            multiChoose.PassNick = txtNick.Text;
            multiChoose.Show();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiChoose multiChoose = new MultiChoose();
            multiChoose.PassNick = txtNick.Text;
            multiChoose.Show();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiChoose multiChoose = new MultiChoose();
            multiChoose.PassNick = txtNick.Text;
            multiChoose.Show();
        }

        private void MySet3_Load(object sender, EventArgs e)
        {
            txtNick.Text = PassNick;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Hide();
            MySet2 mySet2 = new MySet2();
            mySet2.ShowDialog();
        }
    }
}
