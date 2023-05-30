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
    public partial class Login : Form
    {
        TextBox[] txtList;
        const string IDPlaceholder = "아이디";
        const string PWPlaceholder = "비밀번호";
        public Login()
        {
            InitializeComponent();
            txtList = new TextBox[] { txtID, txtPW };
            foreach (var txt in txtList)
            {
                txt.ForeColor = Color.DarkGray;
                if (txt == txtID)
                    txt.Text = IDPlaceholder;
                else if (txt == txtPW)
                    txt.Text = PWPlaceholder;

                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IDPlaceholder | txt.Text == PWPlaceholder)
            {
                txt.ForeColor = Color.Black;
                txt.Text = string.Empty;
                if (txt == txtPW)
                    txtPW.PasswordChar = '●';
            }
        }
        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.ForeColor = Color.DarkGray;
                if (txt == txtID)
                    txt.Text = IDPlaceholder;
                else if (txt == txtPW)
                {
                    txt.Text = PWPlaceholder;
                    txtPW.PasswordChar = default;
                }
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            SignUp newsign = new SignUp();
            this.Hide();
            newsign.ShowDialog();
            this.Show();
        }
        FirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "D0WK5xAXo5XhSBVN8dlcMxuvp4iRQuu0VypUeVbu",
            BasePath = "https://account-fc107-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = client.Get("account/" + txtID.Text);
            Upload upd1 = result.ResultAs<Upload>();

            if (upd1 == null || txtPW.Text != upd1.pw)
            {
                MessageBox.Show("ID가 존재하지 않거나 비밀번호가 정확하지 않습니다.");
            }
            else
            {
                this.Hide();
                MySet2 mySet2 = new MySet2(); 
                mySet2.PassNick = upd1.nickname;
                mySet2.ShowDialog();
            }
        }

        private void Login_Load(object sender, EventArgs e)
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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
