using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Catch_Music.Soloplay;

namespace Catch_Music
{
    delegate void SetTextDelegate(string s);
    public partial class Client : Form
    {
        TcpClient tcpClient = null;
        NetworkStream ntwStream = null;
        int portNumber;
        ChatHandler chatHandler = new ChatHandler(); //서버와 채팅을 실행하는 클래스
        public string musicTitle = null; // 방장이 음악 실행하면 음악의 제목이 저장될 변수
        public DataSet dataset = new ClientINFO();

        private YouTubeService youtubeService;
        private string videoId;
        private string audioUrl;
        private Process audioProcess;
        public string name;
        public string PassNick{get;set;}
        public string apiKey { get; set; }

        Thread dataThread;
        Thread gameCheck;

        public Client()
        {
            InitializeComponent();
            dataGridView1.DataSource = dataset.Tables["clientINFO"];
            dataThread = new Thread(new ThreadStart(refreshData));
            dataThread.Start();
            gameCheck = new Thread(new ThreadStart(gameCheckThread));
            gameCheck.Start();
        }
        private string GetHtml(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string html = reader.ReadToEnd();
                reader.Close();
                response.Close();
                return html;
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했습니다: " + ex.Message);
                return null;
            }
        }
        private string GetAudioUrl(string html)
        {
            int fintWord = html.IndexOf("adaptiveFormats") + 17; //+17
            if (fintWord == -1)
            {
                return null;
            }

            int start = html.IndexOf("[", fintWord);
            if (start == -1)
            {
                return null;
            }

            int end = html.IndexOf("]", start);
            if (end == -1)
            {
                return null;
            }

            string json = html.Substring(start, end - start + 1);

            if (!IsJson(json))
            {
                return null; // 만약 json 형식이 아니라면 null 반환
            }

            dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            foreach (var item in data)
            {
                string mimeType = item.mimeType;
                if (mimeType.StartsWith("audio/mp4"))
                {
                    string url = item.url;
                    return url;
                }
            }

            return null;
        }
        private bool IsJson(string input)
        {
            try
            {
                JToken.Parse(input);
                return true;
            }
            catch (JsonReaderException)
            {
                return false;
            }
        }
        public void PlayMusic(string musicTitle)
        {
            string query = musicTitle;
            SearchResource.ListRequest listRequest = youtubeService.Search.List("snippet");
            listRequest.Q = query;
            listRequest.MaxResults = 1;

            SearchListResponse searchListResponse = listRequest.Execute();
            if (searchListResponse.Items.Count == 0)
            {
                MessageBox.Show("검색 결과가 없습니다.");
                return;
            }

            SearchResult result = searchListResponse.Items[0];
            videoId = result.Id.VideoId;

            string videoUrl = $"https://www.youtube.com/watch?v={videoId}";
            string html = GetHtml(videoUrl);
            if (html == null)
            {
                MessageBox.Show("비디오를 재생할 수 없습니다.");
                return;
            }

            audioUrl = GetAudioUrl(html);
            if (audioUrl == null)
            {
                MessageBox.Show("오디오를 재생할 수 없습니다.");
                return;
            }

            string mpv_path = Path.GetDirectoryName(Path.GetDirectoryName(Environment.CurrentDirectory)) + "\\MPV\\mpv.exe";

            audioProcess = new Process();
            audioProcess.StartInfo.FileName = mpv_path;
            audioProcess.StartInfo.Arguments = $"--no-video {audioUrl}";
            audioProcess.StartInfo.UseShellExecute = false;
            audioProcess.StartInfo.RedirectStandardOutput = true;
            audioProcess.StartInfo.CreateNoWindow = true;
            audioProcess.Start();
        }

        public void StopMusic()
        {
            if (audioProcess != null && !audioProcess.HasExited)
            {
                audioProcess.Kill();
            }
        }



        private void Client_Load(object sender, EventArgs e)
        {
            txtName.Text = PassNick;
            name = txtName.Text;
            youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = apiKey, // Google API Console에서 생성한 인증키를 입력하세요.
                ApplicationName = this.GetType().ToString()
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "서버 들어가기")
            {
                try
                {
                    portNumber = int.Parse(portNumMsg.Text);
                    tcpClient = new TcpClient();
                    tcpClient.Connect(IPAddress.Parse(IPtxtMsg.Text), portNumber);
                    ntwStream = tcpClient.GetStream();

                    chatHandler.Setup(this, ntwStream, this.txtChatMsg);
                    Thread chatThread = new Thread(new ThreadStart(chatHandler.ChatProcess));
                    chatThread.Start();

                    // 서버로 클라이언트가 접속했음을 알리는 메소드
                    Message_Snd("./name " + txtName.Text, true);
                    Message_Snd("서버 : <" + txtName.Text + "> 님께서 접속 하셨습니다.", true);
                    btnConnect.Text = "서버 나가기";
                }
                catch
                {
                    MessageBox.Show("존재하지 않는 서버입니다.");
                }
            }
            else
            {
                Message_Snd("./close " + txtName.Text, true);
                Message_Snd("서버 : <" + txtName.Text + "> 님께서 접속해제 하셨습니다.", false);
                btnConnect.Text = "서버 들어가기";
                chatHandler.ChatClose();
                dataset.Tables["clientINFO"].Rows.Clear();
                ntwStream.Close();
                tcpClient.Close();
                txtChatMsg.Text = "";
            }
        }

        // 서버로 메세지를 보내는 함수
        private void Message_Snd(string lstMessage, Boolean Msg)
        {
            try
            {
                // 보낼 데이터를 읽어 Default 형식의 바이트 스트림으로 변환 해서 전송
                string dataToSend = lstMessage + "\r\n";
                byte[] data = Encoding.UTF8.GetBytes(dataToSend);
                ntwStream.Write(data, 0, data.Length);
            }
            catch (Exception Ex)
            {
                if (Msg == true)
                {
                    MessageBox.Show("서버가 Start 되지 않았거나\r\n" + Ex.Message, "Client");
                    btnConnect.Text = "서버 들어가기";
                    chatHandler.ChatClose();
                    ntwStream.Close();
                    tcpClient.Close();
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

        private void txtMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 누른 키가 Enter인 경우
            {
                // 서버에 접속이 된 상태일 경우
                if (btnConnect.Text == "서버 나가기")
                {
                    Message_Snd("<" + txtName.Text + "> " + txtMsg.Text, true);
                }

                txtMsg.Text = "";
                e.Handled = true; // 이벤트처리 중지
            }
        }

        private void txtMsg_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 누른 키가 Enter인 경우
            {
                // 서버에 접속이 된 상태일 경우
                if (btnConnect.Text == "서버 나가기")
                {
                    Message_Snd("<" + txtName.Text + "> " + txtMsg.Text, true);
                }

                txtMsg.Text = "";
                e.Handled = true; // 이벤트처리 중지
            }
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            gameCheck.Abort();
            dataThread.Abort();
            dataset.Tables["clientINFO"].Rows.Clear();
        }

        private void refreshData()
        {
            DelegatePlus dataRef = () =>
            {
                dataGridView1.Refresh();
            };
            while (true)
            {
                Thread.Sleep(1000);
                dataGridView1.Invoke(dataRef, new object[] { });
            }
        }

        private void gameCheckThread()
        {
            while (true)
            {
                if (dataset.Tables["clientINFO"].Rows.Count != 0)
                {
                    Thread.Sleep(100);
                    for (int i = 0; i < dataset.Tables["clientINFO"].Rows.Count; i++)
                    {
                        if (Convert.ToString(dataset.Tables["clientINFO"].Rows[i]["score"]) == "5")
                        {
                            SetText(Convert.ToString(dataset.Tables["clientINFO"].Rows[i]["name"]) + "님이 승리했습니다!" + "\r\n");
                            for (int j = 0; j < dataset.Tables["clientINFO"].Rows.Count; j++)
                            {
                                // 모든 플레이어들의 점수 초기화
                                dataset.Tables["clientINFO"].Rows[j]["score"] = "0";
                            }
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    public class ChatHandler
    {
        private TextBox txtChatMsg;
        private NetworkStream netStream;
        private StreamReader strReader;
        private Client ce;

        public void Setup(Client ce, NetworkStream netStream, TextBox txtChatMsg)
        {
            this.txtChatMsg = txtChatMsg;
            this.netStream = netStream;
            this.ce = ce;
            this.netStream = netStream;
            this.strReader = new StreamReader(netStream);
        }

        public void ChatClose()
        {
            netStream.Close();
            strReader.Close();
        }

        public void ChatProcess()
        {
            while (true)
            {
                try
                {
                    // 문자열을 받음
                    string lstMessage = strReader.ReadLine();

                    // 서버장이 음악실행을 누른 경우
                    if (lstMessage.StartsWith("./start ") == true)
                    {
                        // Substring을 통해 음악제목 가져오기
                        ce.musicTitle = lstMessage.Substring(8);
                   

                        // 서버 폼에서 음악실행 버튼을 누르면
                        // 실행할 노래의 제목이 musicTitle에 저장됩니다.

                        // 음악 실행하는 코드 작성(ce.musicTitle 변수가 음악 제목)
                        //server에서 노래 재생 버튼을 누르면 시간차를 두고 client에서도 노래가 재생된다.
                        //시연 할때는 아래 코드를 주석처리 할 예정(기능은 확인 됬으니 원활한 시연을 위해서)
                        ce.PlayMusic(ce.musicTitle);

                        continue;
                    }

                    //서버에서 음악중지가 되었을 경우
                    if (lstMessage.StartsWith("./stop ") == true)
                    {
                        //얘는 딜레이 없이 서버에서 음악이 중지되면, 노래가 거의 동시에 중지됨.
                        ce.StopMusic();
                        continue;
                    }

                    if (lstMessage.StartsWith("./name ") == true)
                    {
                        string splitT = lstMessage.Substring(7);
                        string[] dataInfo = splitT.Split('\x020'); // 공백 기준으로 나누기 -> 공백이 없으면? -> 에러 안나면 정상
                        // 닉네임 저장
                        if (ce.dataset.Tables["clientINFO"].Rows.Count == 0)
                        {
                            int ch = 0;
                            foreach (string a in dataInfo)
                            {
                                if (ch == 0)
                                {
                                    //ce.SetText(a + "\r\n");
                                    ce.dataset.Tables["clientINFO"].Rows.Add(new object[] { a.Substring(0, (a.Length) - 1), a.Substring(a.Length - 1) });
                                    ch = 1;
                                    continue;
                                }
                                ce.SetText(a + "\r\n");
                                // 수정필요
                                ce.dataset.Tables["clientINFO"].Rows.Add(new object[] { a.Substring(0, (a.Length) - 1), a.Substring(a.Length - 1) });
                            }
                            ch = 0;
                            continue;
                        }
                        else ce.dataset.Tables["clientINFO"].Rows.Add(new object[] { splitT, 0 });
                        continue;
                    }

                    if (lstMessage.StartsWith("./hint1 ") == true)
                    {
                        ce.SetText("<유튜브댓글>" + lstMessage.Substring(8) + "\r\n");
                        continue;
                    }

                    if (lstMessage == "./hint2")
                    {
                        ce.SetText("hint2!!!!!!!!!" + "\r\n");
                        continue;
                    }

                    if (lstMessage == "./hint3")
                    {
                        ce.SetText("hint3!!!!!!!!!" + "\r\n");
                        continue;
                    }

                    if (lstMessage.StartsWith("./plus ") == true)
                    {
                        // 서버장이 지정한 대상에게 점수 추가
                        foreach (DataRow row in ce.dataset.Tables["clientINFO"].Rows)
                        {
                            if (Convert.ToString(row["name"]) == lstMessage.Substring(7))
                            {
                                row["score"] = (int.Parse(Convert.ToString(row["score"])) + 1).ToString();
                            }
                        }

                        ce.SetText("서버 : " + lstMessage.Substring(7) + "님 정답! 1점 추가!" + "\r\n");

                        continue;
                    }

                    if (lstMessage.StartsWith("./close ") == true)
                    {
                        foreach (DataRow row in ce.dataset.Tables["clientINFO"].Rows)
                        {
                            if (Convert.ToString(row["name"]) == lstMessage.Substring(8))
                            {
                                ce.dataset.Tables["clientINFO"].Rows.Remove(row);
                                break;
                            }
                        }
                        ce.SetText("서버 : " + lstMessage.Substring(8) + "님이 퇴장하셨습니다." + "\r\n");
                        continue;
                    }

                    if (lstMessage != null && lstMessage != "")
                    {
                        // 대리자 사용
                        ce.SetText(lstMessage + "\r\n");
                        continue;
                    }
                }
                catch (System.Exception)
                {
                    break;
                }
            }
        }
    }
}
