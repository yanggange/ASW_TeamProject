using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Catch_Music
{
    public partial class Soloplay : Form
    {
        delegate void SetTextDelegate(string s);
        public string name; // 로그인하면 가져오는 닉네임을 저장하는 변수
        public string musicTitle; // 게임시작시 실행되는 음악의 제목이 저장되는 변수
        public string musicMakeP; // 게임시작시 실행되는 음악의 제작자가 저장되는 변수
        public int score;
        private int maxScore = 5; // 얻으면 종료되는 점수

        public Soloplay()
        {
            InitializeComponent();
            // Nickname.Text = name;
            score = 0;
            txtChatMsg.Text += name + "님 반갑습니다. 왼쪽 하단의 버튼을 눌러 게임을 시작하세요!\r\n";
            txtMsg.Enabled = false;
            hintBtn1.Enabled = false;
            hintBtn2.Enabled = false;
            hintBtn3.Enabled = false;
        }

        private void PlayerText(string text)
        {
            if (this.txtChatMsg.InvokeRequired)
            {
                SetTextDelegate d = new SetTextDelegate(PlayerText); // 대리자 선언
                this.Invoke(d, new object[] { "<" + name + "> " + text + "\r\n"}); // 대리자를 통해 글을 쓰는
            }
            else // UI Thread 이면
            {
                txtChatMsg.Text += "<" + name + "> " + text + "\r\n";
            }
        }

        private void ServerText(string text)
        {
            if (this.txtChatMsg.InvokeRequired)
            {
                SetTextDelegate d = new SetTextDelegate(ServerText); // 대리자 선언
                this.Invoke(d, new object[] { "< 서버 > " + text + "\r\n" }); // 대리자를 통해 글을 쓰는
            }
            else // UI Thread 이면
            {
                txtChatMsg.Text += text;
            }
        }

        private void txtMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 누른 키가 Enter인 경우
            {
                PlayerText(txtMsg.Text);
                txtMsg.Text = "";
            }
        }

        private void Soloplay_Load(object sender, EventArgs e)
        {

        }

        private void soloGame()
        {
            ServerText("게임이 곧 시작합니다...");
            while (score < maxScore) // maxScore점을 얻으면 종료
            {
                ///
                /// 여기에 db 코드작성
                /// 노래정보들이 저장되어 있는 db에서 랜덤하게 하나를 가져와
                /// 정보를 musicTitle, musicMakeP 변수에 저장
                ///

                Thread.Sleep(1000);
                ServerText("3...");
                Thread.Sleep(1000);
                ServerText("2...");
                Thread.Sleep(1000);
                ServerText("1...");

                ///
                /// 여기에 유튜브 API 코드작성
                /// musicTitle, 즉 실행할 음악제목이 들어있는 변수를 가지고
                /// 유튜브의 음원을 실행하는 코드 작성
                ///

                while (true)
                {
                    // 엔터키 누른것을 어떻게 인지하나?
                }
                ServerText("정답입니다!!!");
            }
        }

        // 게임시작 버튼 클릭 시
        private void button1_Click(object sender, EventArgs e)
        {
            txtMsg.Enabled = true;
            hintBtn1.Enabled = true;
            hintBtn2.Enabled = true;
            hintBtn3.Enabled = true;

            Thread gameThread = new Thread(new ThreadStart(soloGame));
            gameThread.Start();  
        }

        private void hintBtn1_Click(object sender, EventArgs e)
        {

        }

        private void hintBtn2_Click(object sender, EventArgs e)
        {

        }

        private void hintBtn3_Click(object sender, EventArgs e)
        {

        }
    }
}
