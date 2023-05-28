using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Catch_Music
{

    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        FirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "D0WK5xAXo5XhSBVN8dlcMxuvp4iRQuu0VypUeVbu",
            BasePath = "https://account-fc107-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private void SignUp_Load(object sender, EventArgs e)
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var result = client.Get("account/" + txtID.Text);
            Upload upd1 = result.ResultAs<Upload>();

            if (upd1 != null)
            {
                MessageBox.Show("ID가 중복입니다.");
            }
            else if (txtPW.Text != txtPWch.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
            }
            else if (txtBirth.Text.Length != 8)
            {
                MessageBox.Show("생년월일이 올바르지 않습니다.");
            }
            else
            {

                Upload upd2 = new Upload()
                {
                    name = txtName.Text,
                    id = txtID.Text,
                    pw = txtPW.Text,
                    birth = txtBirth.Text,
                    nickname = txtNick.Text
                };
                var send = client.Set("account/" + txtID.Text, upd2);
                MessageBox.Show("회원가입이 완료되었습니다.");

                Login login = new Login();
                this.Hide();
                login.ShowDialog();
            }
        }
    }
}
