﻿using System;
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
    public partial class MultiChoose : Form
    {
        public string name; // 로그인 했을 때 주어지는 닉네임을 저장할 변수
        public string PassNick
        { get; set; }
        public string apiKey { get; set; }
        public string key;

        public MultiChoose()
        {
            InitializeComponent();
        }

        private void makeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Server sv = new Server();
            sv.apiKey = key;
            sv.ShowDialog(); // 테스트때문에 ShowDialog()가 아닌 Show() 사용
            this.Show();
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client ce = new Client();
            ce.PassNick = txtNick.Text;
            ce.apiKey = key;
            ce.ShowDialog(); // 테스트때문에 ShowDialog()가 아닌 Show() 사용
            this.Show();
        }

        private void MultiChoose_Load(object sender, EventArgs e)
        {
            txtNick.Text = PassNick;
            key = apiKey;
        }
    }
}
