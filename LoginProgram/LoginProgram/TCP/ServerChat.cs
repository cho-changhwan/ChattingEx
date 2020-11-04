using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProgram.Mysql
{
    public class ServerChat
    {
        public delegate void DisplayText(string strMessage);

        public DisplayText DelegateDisplayText;

        private static int m_Counter = 0;
        private TcpListener m_Server = null;
        private TcpClient m_Client = null;
        private string strDate;
        private Dictionary<TcpClient, string> m_Clients;

        public static int Counter
        {
            get => m_Counter;
        }

        public TcpListener Server
        {
            get => m_Server;
            set => m_Server = value;
        }

        public TcpClient Client
        {
            get => m_Client;
            set => m_Client = value;
        }

        public string Date
        {
            get => strDate;
            set => strDate = value;
        }

        public Dictionary<TcpClient, string> Clients
        {
            get => m_Clients;
            set => m_Clients = value;
        }


        public ServerChat()
        {
            Clients = new Dictionary<TcpClient, string>();
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();
        }

        public void ServerChats()
        {
            Client = null;
            Clients = null;
        }

        private void InitSocket()
        {
            Server = new TcpListener(IPAddress.Any, 9999);
            Client = default(TcpClient);
            Server.Start();

            DelegateDisplayText(">>서버 대기중<<");

            while (true)
            {
                try
                {
                    m_Counter++;
                    Client = Server.AcceptTcpClient();

                    DelegateDisplayText(">>연결 수락<<");

                    NetworkStream stream = Client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string user_name = Encoding.Unicode.GetString(buffer, 0, bytes);
                    user_name = user_name.Substring(0, user_name.IndexOf("$"));

                    Clients.Add(Client, user_name);

                    string listViewReresh = string.Empty;

                    listViewReresh += "*";

                    foreach (var pair in Clients)
                    {
                        listViewReresh += pair.Value + "*";
                    }
                    
                    SendMessageAll(user_name + "님이 입장하셨습니다", "", false);

                    Thread.Sleep(500);

                    SendMessageAll(listViewReresh, "", false);

                    HandleClass handleClient = new HandleClass(); // 클라이언트 추가
                    handleClient.OnReceived += new HandleClass.MessageDisplayHandler(OnReceived);
                    handleClient.OnDisconnected += new HandleClass.DisconnectedHandler(OnHandledClientDisconnected);
                    handleClient.StartClient(Client, Clients);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            Client.Close();
            Server.Stop();
        }

        public void SendMessageAll(string strMessage, string user_name, bool flag)
        {
            try
            {
                //string listViewReSet = string.Empty;
                //listViewReSet += "@";
                foreach (var pair in Clients)
                {
                    strDate = DateTime.Now.ToString("yyyy.MM.dd. HH:mm:ss"); // 현재 날짜 받기
                    TcpClient client = pair.Key as TcpClient;
                    NetworkStream stream = client.GetStream();

                    byte[] buffer = null;
                    //listViewReSet += pair.Value + "@";
                    if (flag)
                    {
                        if (strMessage.Equals("leaveChat"))
                        {
                            buffer = Encoding.Unicode.GetBytes(user_name + " 님이 대화방을 나갔습니다.");
                        }
                        else
                        {
                            buffer = Encoding.Unicode.GetBytes("[ " + strDate + " ] " + user_name + " : " + strMessage);
                        }
                    }
                    else
                    {
                        buffer = Encoding.Unicode.GetBytes(strMessage);
                    }

                    stream.Write(buffer, 0, buffer.Length);
                    stream.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void OnReceived(string strMessage, string user_name) // cleint로 부터 받은 데이터
        {
            try
            {
                if (strMessage.Equals("leaveChat"))
                {
                    string displayMessage = "leave user : " + user_name;
                    DelegateDisplayText(displayMessage);
                    SendMessageAll("leaveChat", user_name, true);
                }
                else
                {
                    string[] parsed = strMessage.Split('$');
                    if (parsed.Length == 3)
                    {
                        string displayMessage = "From client : " + user_name + " : " + parsed[0];
                        DelegateDisplayText(displayMessage);
                        SendMessageSingle(parsed[0], user_name, user_name);
                        SendMessageSingle(parsed[0], user_name, parsed[1]); // 선택받은 Client에게 전송
                    }
                    else
                    {
                        string displayMessage = "From client : " + user_name + " : " + parsed[0];
                        DelegateDisplayText(displayMessage); // Server단에 출력
                        SendMessageAll(parsed[0], user_name, true); // 모든 Client에게 전송
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void OnHandledClientDisconnected(TcpClient Client) // cleint 접속 해제 핸들러
        {
            try
            {
                if (Clients.ContainsKey(Client))
                {
                    Clients.Remove(Client);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void SendMessageSingle(string strMessage, string user_name, string strChatId)
        {
            try
            {
                foreach (var pair in Clients)
                {
                    if (pair.Value.Equals(strChatId))
                    {
                        strDate = DateTime.Now.ToString("yyyy.MM.dd. HH:mm:ss"); // 현재 날짜 받기
                        TcpClient client = pair.Key as TcpClient;
                        NetworkStream stream = client.GetStream();

                        byte[] buffer = null;
                        buffer = Encoding.Unicode.GetBytes("[ " + strDate + " ] [귓속말]" + user_name + " : " + strMessage);

                        stream.Write(buffer, 0, buffer.Length);
                        stream.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
