using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoginProgram.Mysql
{
    class HandleClass
    {
        #region Private Member Variables

        private TcpClient m_client;
        private Dictionary<TcpClient, string> m_clients;

        #endregion Private Member Variables

        #region Constructors

        public HandleClass()
        {
            Client = null;
            Clients = null;
        }

        #endregion Constructors

        #region Public Properties

        public TcpClient Client
        {
            get => m_client;
            set => m_client = value;
        }

        public Dictionary<TcpClient, string> Clients
        {
            get => m_clients;
            set => m_clients = value;
        }

        #endregion Public Properties

        public void StartClient(TcpClient m_Client, Dictionary<TcpClient, string> m_Clients)
        {
            try
            {
                Client = m_Client;
                Clients = m_Clients;

                Thread chatThread = new Thread(DoChat);
                chatThread.IsBackground = true;
                chatThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public delegate void MessageDisplayHandler(string strMessage, string userName);
        public event MessageDisplayHandler OnReceived;

        public delegate void DisconnectedHandler(TcpClient m_Client);
        public event DisconnectedHandler OnDisconnected;

        private void DoChat()
        {
            NetworkStream Stream = null;
            try
            {
                byte[] buffer = new byte[1024];
                string msg = string.Empty;
                int bytes = 0;
                int MessageCount = 0;

                while (true)
                {
                    MessageCount++;
                    Stream = Client.GetStream();
                    bytes = Stream.Read(buffer, 0, buffer.Length);
                    msg = Encoding.Unicode.GetString(buffer, 0, bytes);

                    if (OnReceived != null)
                        OnReceived(msg, Clients[Client].ToString());
                }
            }
            catch (SocketException ex)
            {
                Trace.WriteLine(string.Format("doChat - SocketException : {0}", ex.Message));
                Console.WriteLine(ex.ToString());
                if (Client != null)
                {
                    if (OnDisconnected != null)
                        OnDisconnected(Client);

                    Client.Close();
                    Stream.Close();
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(string.Format("doChat - Exception : {0}", ex.Message));
                Console.WriteLine(ex.ToString());
                if (Client != null)
                {
                    if (OnDisconnected != null)
                        OnDisconnected(Client);

                    Client.Close();
                    Stream.Close();
                }
            }
        }
    }
}

