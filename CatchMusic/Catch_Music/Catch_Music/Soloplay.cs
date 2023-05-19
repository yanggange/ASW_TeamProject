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
        delegate void InitDelegate();
        public string name = "unknown"; // 로그인하면 가져오는 닉네임을 저장하는 변수
        public string musicTitle = ""; // 게임시작시 실행되는 음악의 제목이 저장되는 변수
        public string musicMakeP = ""; // 게임시작시 실행되는 음악의 제작자가 저장되는 변수
        public int score;
        private int maxScore = 5; // 얻으면 종료되는 점수
        public string checkText = "fjciwknkfl123"; // 적은 1줄의 text가 기록되는 변수
        private int gameDiff = 10; // 기본으로 설정 된 난이도
        Thread gameThread;

        public Soloplay()
        {
            InitializeComponent();
            Nickname.Text = name;
            score = 0;
            txtChatMsg.Text += "< 서버 > " + name + "님 반갑습니다!\r\n";
            txtChatMsg.Text += "< 서버 > 왼쪽하단의 난이도를 고른뒤 게임을 시작하세요!\r\n";
            txtChatMsg.Text += "< 서버 > 난이도를 고르지 않을 시 보통 난이도로 설정 됩니다.\r\n";
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

        private void settingInit()
        {
            txtMsg.Enabled = false;
            hintBtn1.Enabled = false;
            hintBtn2.Enabled = false;
            hintBtn3.Enabled = false;
            groupBox1.Enabled = true;
            gameStartBtn.Enabled = true;
            txtChatMsg.Text = "다시 하시려면 왼쪽의 게임시작버튼을 눌러주세요!\r\n";
        }

        private void txtMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 누른 키가 Enter인 경우
            {
                PlayerText(txtMsg.Text);
                checkText = txtMsg.Text;
                txtMsg.Text = "";
            }
        }

        private void Soloplay_Load(object sender, EventArgs e)
        {
        }

        private void soloGame()
        {
            ServerText("게임이 곧 시작합니다...");
            if (gameDiff == 15)
            {
                ServerText("아니... 이렇게 쉽게...?");
            }
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
                /// 게임 난이도에 대한 시간변수(15초, 10초, 5초)는 gameDiff에 저장되어 있습니다.
                ///

                while (true)
                {
                    // 엔터키 누른것을 어떻게 인지하나? -> 변수의 값변화로
                    if (checkText == musicTitle)
                    {
                        ServerText("정답입니다!!!");
                        checkText = "fjciwknkfl123";
                        score++;
                        break;
                    }
                }
            }

            // 게임 클리어
            // 초기 설정으로 되돌림
            ServerText("게임클리어!");
            ServerText("3초뒤에 초기화 됩니다...");
            Thread.Sleep(3000);
            checkText = "fjciwknkfl123";
            score = 0;
            gameDiff = 10;
            InitDelegate d = new InitDelegate(settingInit);
            this.Invoke(d, new object[] { });
        }

        // 게임시작 버튼 클릭 시
        private void button1_Click(object sender, EventArgs e)
        {
            txtMsg.Enabled = true;
            hintBtn1.Enabled = true;
            hintBtn2.Enabled = true;
            hintBtn3.Enabled = true;

            groupBox1.Enabled = false;
            gameStartBtn.Enabled = false;

            gameThread = new Thread(new ThreadStart(soloGame));
            gameThread.Start();  
        }

        private void hintBtn1_Click(object sender, EventArgs e)
        {
            string hintText = "";
            ///
            /// 힌트에 관련된 정보를 db에서 가져와 hintText 변수에 저장하는 코드작성
            ///
            ServerText(hintText);
        }

        private void hintBtn2_Click(object sender, EventArgs e)
        {
            string hintText = "";
            ///
            /// 힌트에 관련된 정보를 db에서 가져와 hintText 변수에 저장하는 코드작성
            ///
            ServerText(hintText);
        }

        private void hintBtn3_Click(object sender, EventArgs e)
        {
            string hintText = "";
            ///
            /// 힌트에 관련된 정보를 db에서 가져와 hintText 변수에 저장하는 코드작성
            ///
            ServerText(hintText);
        }

        private void Soloplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gameThread != null)
            {
                // 스레드 종료
                gameThread.Abort();
            }
        }

        private void hignBtn_CheckedChanged(object sender, EventArgs e)
        {
            gameDiff = 5;
        }

        private void nomalBtn_CheckedChanged(object sender, EventArgs e)
        {
            gameDiff = 10;
        }

        private void easyBtn_CheckedChanged(object sender, EventArgs e)
        {
            gameDiff = 15;
        }
    }
}
