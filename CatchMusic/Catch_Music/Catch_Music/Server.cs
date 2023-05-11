using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_Music
{
    public partial class Server : Form
    {
        delegate void SetTextDelegate(string s);
        int portNumber;
        TcpListener chatServer;
        string musicTitle = null;
        public static ArrayList clientSocketArray = new ArrayList();

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            IPtxt.Text = GetIP();
        }

        // 이더넷 or Wi-Fi의 IP를 가져오는 함수
        public static string GetIP()
        {
            string IPs = "";

            //모든 네트워크 인터페이스 얻기
            foreach (var network in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (network.Name == "이더넷" || network.Name == "Wi-Fi")
                {
                    //IPv4를 지원하는 네트워크 확인
                    if (network.Supports(NetworkInterfaceComponent.IPv4) == true)
                    {
                        // 사용하는 네트워크인지 확인
                        if (NetworkInterface.GetIsNetworkAvailable() && network.OperationalStatus == OperationalStatus.Up)
                        {
                            //Unicast 주소가 할당된 ip 얻기
                            foreach (UnicastIPAddressInformation uniIp in network.GetIPProperties().UnicastAddresses)
                            {
                                if (uniIp.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                                {
                                    string ipAddress = uniIp.Address.ToString();
                                    if (ipAddress != null)
                                    {
                                        IPs = ipAddress;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return IPs;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (portNumTxt.Text != "")
            {
                portNumber = int.Parse(portNumTxt.Text);
                chatServer = new TcpListener(IPAddress.Parse(GetIP()), portNumber); // 포트
            }
            else { return; }

            try
            {
                Thread waitThread = new Thread(new ThreadStart(AcceptClient));
                //서버가 종료 상태인경우
                if (OnOffsv.Tag.ToString() == "Stop")
                {
                    chatServer.Start();
                    waitThread.Start();

                    OnOffsv.Text = "방 열림";
                    OnOffsv.Tag = "Start";
                    btnStart.Text = "방 닫기";
                    portNumTxt.Enabled = false;

                    musicTitleMsg.Enabled = true;
                    musicStartBtn.Enabled = true;
                    hintBtn1.Enabled = true;
                    hintBtn2.Enabled = true;
                    hintBtn3.Enabled = true;
                    answerTxt.Enabled = true;
                    musicAnswerP.Enabled = true;
                }
                else
                {
                    chatServer.Stop();
                    foreach (Socket soket in Server.clientSocketArray)
                    {
                        soket.Close();
                    }
                    clientSocketArray.Clear();

                    OnOffsv.Text = "방 닫기";
                    OnOffsv.Tag = "Stop";
                    btnStart.Text = "방 열기";
                    txtChatMsg.Text = "";
                    portNumTxt.Enabled = true;

                    musicTitleMsg.Enabled = false;
                    musicStartBtn.Enabled = false;
                    hintBtn1.Enabled = false;
                    hintBtn2.Enabled = false;
                    hintBtn3.Enabled = false;
                    answerTxt.Enabled = false;
                    musicAnswerP.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버 시작 오류 :" + ex.Message);
            }
        }

        // 무한루프 돌면서 client 접속을 기다리는
        private void AcceptClient()
        {
            Socket socketClient = null;
            while (true)
            {
                try
                {
                    socketClient = chatServer.AcceptSocket();

                    ClientHandler clientHandler = new ClientHandler();
                    clientHandler.ClientHandler_Setup(this, socketClient, this.txtChatMsg);

                    Thread thd_ChatProcess = new Thread(new ThreadStart(clientHandler.Chat_Process));
                    thd_ChatProcess.Start();
                }
                catch (System.Exception)
                {
                    Server.clientSocketArray.Remove(socketClient);
                    break;
                }
            }
        }

        public void SetText(string text)
        {
            if (this.txtChatMsg.InvokeRequired)
            {
                SetTextDelegate d = new SetTextDelegate(SetText); // 대리자 선언
                this.Invoke(d, new object[] { text }); // 대리자를 통해 글을 쓰는
            }
            else // UI Thread 이면
            {
                this.txtChatMsg.AppendText(text);
            }
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (clientSocketArray.Count > 0)
            {
                chatServer.Stop();
                foreach (Socket soket in Server.clientSocketArray)
                {
                    soket.Close();
                }
                clientSocketArray.Clear();
            }

           Environment.Exit(0); // 테스트용
        }

        private void musicAnswerP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 적고 엔터키를 누르면 한라운드 끝
                // 정답자에게 점수를 추가해야한다
                string lstMessage = "./plus " + musicAnswerP.Text;
                if (lstMessage != null && lstMessage != "")
                {
                    txtChatMsg.Text = txtChatMsg.Text + "누군가에게 서버장님이 점수를 추가했습니다!" + "\r\n";
                    byte[] bytSand_Data = Encoding.UTF8.GetBytes(lstMessage + "\r\n");
                    lock (Server.clientSocketArray)
                    {
                        // 접속해 있는 모든 클라이언트에게 글을 쓰는
                        foreach (Socket soket in Server.clientSocketArray)
                        {
                            NetworkStream stream = new NetworkStream(soket);
                            stream.Write(bytSand_Data, 0, bytSand_Data.Length);
                        }
                    }
                }
            }
        }

        private void musicStartBtn_Click(object sender, EventArgs e)
        {
            // 누르면 실행하는 코드
            // 모든 클라이언트들에게 노래실행 코드와 제목을 보내는 방법은?
            string lstMessage = "./start " + musicTitleMsg.Text;
            if (lstMessage != null && lstMessage != "")
            {
                txtChatMsg.Text = txtChatMsg.Text + "게임실행버튼을 서버장이 눌렀습니다." + "\r\n";
                byte[] bytSand_Data = Encoding.UTF8.GetBytes(lstMessage + "\r\n");
                lock (Server.clientSocketArray)
                {
                    // 접속해 있는 모든 클라이언트에게 글을 쓰는
                    foreach (Socket soket in Server.clientSocketArray)
                    {
                        NetworkStream stream = new NetworkStream(soket);
                        stream.Write(bytSand_Data, 0, bytSand_Data.Length);
                    }
                }
            }
        }

        private void hintBtn1_Click(object sender, EventArgs e)
        {
            // 모든 클라이언트들에게 힌트1실행 코드를 보내는 방법은?
            string lstMessage = "./hint1";
            if (lstMessage != null && lstMessage != "")
            {
                txtChatMsg.Text = txtChatMsg.Text + "힌트1버튼을 서버장이 눌렀습니다." + "\r\n";
                byte[] bytSand_Data = Encoding.UTF8.GetBytes(lstMessage + "\r\n");
                lock (Server.clientSocketArray)
                {
                    // 접속해 있는 모든 클라이언트에게 글을 쓰는
                    foreach (Socket soket in Server.clientSocketArray)
                    {
                        NetworkStream stream = new NetworkStream(soket);
                        stream.Write(bytSand_Data, 0, bytSand_Data.Length);
                    }
                }
            }
        }

        private void hintBtn2_Click(object sender, EventArgs e)
        {
            // 모든 클라이언트들에게 힌트2실행 코드를 보내는 방법은?
            string lstMessage = "./hint2";
            if (lstMessage != null && lstMessage != "")
            {
                txtChatMsg.Text = txtChatMsg.Text + "힌트2버튼을 서버장이 눌렀습니다." + "\r\n";
                byte[] bytSand_Data = Encoding.UTF8.GetBytes(lstMessage + "\r\n");
                lock (Server.clientSocketArray)
                {
                    // 접속해 있는 모든 클라이언트에게 글을 쓰는
                    foreach (Socket soket in Server.clientSocketArray)
                    {
                        NetworkStream stream = new NetworkStream(soket);
                        stream.Write(bytSand_Data, 0, bytSand_Data.Length);
                    }
                }
            }
        }

        private void hintBtn3_Click(object sender, EventArgs e)
        {
            // 모든 클라이언트들에게 힌트2실행 코드를 보내는 방법은?
            string lstMessage = "./hint3";
            if (lstMessage != null && lstMessage != "")
            {
                txtChatMsg.Text = txtChatMsg.Text + "힌트3버튼을 서버장이 눌렀습니다." + "\r\n";
                byte[] bytSand_Data = Encoding.UTF8.GetBytes(lstMessage + "\r\n");
                lock (Server.clientSocketArray)
                {
                    // 접속해 있는 모든 클라이언트에게 글을 쓰는
                    foreach (Socket soket in Server.clientSocketArray)
                    {
                        NetworkStream stream = new NetworkStream(soket);
                        stream.Write(bytSand_Data, 0, bytSand_Data.Length);
                    }
                }
            }
        }
    }

    public class ClientHandler
    {
        private TextBox txtChatMsg;
        private Socket socketClient;
        private NetworkStream netStream;
        private StreamReader strReader;
        private Server sv;

        public void ClientHandler_Setup(Server sv, Socket socketClient, TextBox txtChatMsg)
        {
            this.txtChatMsg = txtChatMsg;
            this.socketClient = socketClient;
            this.netStream = new NetworkStream(socketClient);
            Server.clientSocketArray.Add(socketClient); // 클라이언트 소켓을 List에 담음
            this.strReader = new StreamReader(netStream);
            this.sv = sv;
        }

        public void Chat_Process()
        {
            while (true)
            {
                try
                {
                    // 클라이언트에게 문자열을 받음
                    string lstMessage = strReader.ReadLine();
                    if (lstMessage != null && lstMessage != "")
                    {
                        sv.SetText(lstMessage + "\r\n"); // delegate를 사용
                        byte[] bytSand_Data = Encoding.UTF8.GetBytes(lstMessage + "\r\n");
                        lock (Server.clientSocketArray)
                        {
                            // 접속해 있는 모든 클라이언트에게 글을 쓰는
                            foreach (Socket soket in Server.clientSocketArray)
                            {
                                NetworkStream stream = new NetworkStream(soket);
                                stream.Write(bytSand_Data, 0, bytSand_Data.Length);
                            }
                        }
                    }
                }
                catch
                {
                    //MessageBox.Show("채팅 오류 :" + ex.Message);
                    Server.clientSocketArray.Remove(socketClient);
                    break;
                }
            }
        }
    }
}
