using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace LoginProgram.Mysql
{
    public delegate void DisplayText(string strMessage);
    public delegate void ListRefresh(string[] strIds);
    public delegate void ListReSet(string[] strId);
    class ClientChat
    {
        public DisplayText DelegateDisplayText;
        public ListRefresh DelegateListRefresh;
        public ListReSet DelegateListReSet;

        private TcpClient m_Client;
        private NetworkStream m_Stream;
        private string strMessage;

        public bool IsInit;

        public TcpClient Client
        {
            get => m_Client;
            set => m_Client = value;
        }

        public NetworkStream Stream
        {
            get => m_Stream;
            set => m_Stream = value;
        }

        public string Message
        {
            get => strMessage;
            set => strMessage = value;
        }
        public string strSend
        {
            get; set;
        }
        public string strName
        {
            get; set;
        }

        public ClientChat()
        {

            Client = new TcpClient();
            m_Stream = default(NetworkStream);
            strMessage = string.Empty;
        }

        private void GetMessage()
        {
            try
            {
                while (true)
                {
                    m_Stream = Client.GetStream();
                    int bufferSize = Client.ReceiveBufferSize;
                    byte[] buffer = new byte[bufferSize];
                    int bytes = m_Stream.Read(buffer, 0, buffer.Length);

                    strMessage = Encoding.Unicode.GetString(buffer, 0, bytes);

                    if (strMessage[0] == '*')
                    {
                        string[] strIds = strMessage.Split('*');
                        List<string> strList = new List<string>();

                        foreach(var element in strIds)
                        {
                            if (!element.Equals(""))
                            {
                                strList.Add(element);
                            }
                        }
                        DelegateListRefresh(strList.ToArray());
                    }
                    //else if (strMessage[0] == '@')
                    //{
                    //    string[] strId = strMessage.Split('@');
                    //    DelegateListReSet(strId);
                    //}
                    else
                    {
                        DelegateDisplayText(strMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public ClientChat(string strAddress)
        {
            try
            {
                IPHostEntry _host = Dns.GetHostEntry(Dns.GetHostName());
                Client = new TcpClient();
                m_Stream = default(NetworkStream);
                strMessage = string.Empty;
                IsInit = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public bool SendClick(string strMessage)
        {
            bool bResult = false;
            try
            {
                if (CheckData(strMessage))
                {
                    byte[] buffer = Encoding.Unicode.GetBytes(strMessage + "$");
                    m_Stream.Write(buffer, 0, buffer.Length);
                    m_Stream.Flush();
                    bResult = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                bResult = false;
            }
            return bResult;
        }

        public void Connectt(string strAddress, int nPort, string strName)
        {
            if (IsInit == false)
            {
                try
                {
                    Client.Connect(strAddress, nPort);

                    m_Stream = Client.GetStream();

                    strMessage = "Connected to Chat Server";

                    DelegateDisplayText(strMessage);

                    byte[] buffer = Encoding.Unicode.GetBytes(strName + "$");
                    m_Stream.Write(buffer, 0, buffer.Length);
                    m_Stream.Flush();

                    Thread getMessageFromServerThread = new Thread(GetMessage);
                    getMessageFromServerThread.IsBackground = true;
                    getMessageFromServerThread.Start();

                    MessageBox.Show("연결완료");
                    IsInit = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("서버를 연결하세요");
                    Console.WriteLine(ex.ToString());
                    IsInit = false;
                }
            }
            else if (Client.Equals("/exit"))
            {
                Disconnect();
                Console.WriteLine("클라이언트 종료");
            }
            else
            {

                if (!ConnectClient())
                {
                    MessageBox.Show("이미 연결");
                }
                else
                {
                    MessageBox.Show("이미 연결됨");
                }
            }
        }
        void Disconnect()
        {
            byte[] buffer = Encoding.Default.GetBytes("채팅종료" + "$");
            Stream.Write(buffer, 0, buffer.Length);
            Stream.Flush();
            Stream.Close();
            Client.Close();
            Application.ExitThread();
        }
        void Disconnect(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes("채팅종료" + "$");
            Stream.Write(buffer, 0, buffer.Length);
            Stream.Flush();
            Stream.Close();
            Client.Close();
            Application.ExitThread();
        }

        public void SingleChat(String strChatId)
        {
            try
            {
                byte[] buffer = Encoding.Unicode.GetBytes(strSend + "$" + strChatId + "$");
                m_Stream.Write(buffer, 0, buffer.Length);
                m_Stream.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public Boolean ConnectClient() // 연결확인
        {
            if (Client.Connected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean CheckSend(string strMessage) //빈칸체크용
        {
            try
            {
                if (string.IsNullOrEmpty(strMessage))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //return false;
            }
            return false;
        }
        public Boolean CheckData(String strMessage) // 메세지 글 체크
        {
            bool bResult = false;
            if (!CheckSend(strMessage))
            {
                bResult = true;
            }
            else
            {
                Console.WriteLine("메세지를 작성하지 않았습니다.");
            }
            return bResult;
        }
    }
}
