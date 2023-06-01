using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace Catch_Music
{
    public partial class Song : Form
    {
        public Song()
        {
            InitializeComponent();
        }
        FirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "D0WK5xAXo5XhSBVN8dlcMxuvp4iRQuu0VypUeVbu",
            BasePath = "https://account-fc107-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (true)
            {
                var result = client.Get("music/" + i);
                SongInfo s = result.ResultAs<SongInfo>();
                if (s != null)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            SongInfo s1 = new SongInfo()
            {
                musicMakeP = textBox1.Text,
                musicTitle = textBox2.Text,
                musicSearch = textBox1.Text + " 무대",
                musicYear = textBox3.Text,
            };
            var send = client.Set("music/" + i, s1);
            MessageBox.Show("추가 완료");
        }

        private void Song_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fbc);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
