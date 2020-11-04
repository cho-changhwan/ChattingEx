using LoginProgram.Mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginProgram
{

    public partial class ClientChatting : Form
    {
        ClientChat CliChat;
        Connection mCon;
        ServerChat SerChat;

        //public string bufferedList;
        //  public List users = new List();

        public ClientChatting()
        {
            CliChat = new ClientChat();
            SerChat = new ServerChat();
            CliChat.DelegateDisplayText += DisplayText;
            CliChat.DelegateListRefresh += ListRefresh;
            CliChat.DelegateListReSet += ListReSet;
            InitializeComponent();
        }
        public ClientChatting(string id, Connection con)
        {
            CliChat = new ClientChat();
            CliChat.DelegateDisplayText += DisplayText;
            CliChat.DelegateListRefresh += ListRefresh;
            CliChat.DelegateListReSet += ListReSet;
            InitializeComponent();
            tbox_name.Text = id;
            mCon = con;
        }
        public bool IsInit;
        private void DisplayText(string strText) //Client 화면
        {
            try
            {
                if (tbox_client.InvokeRequired)
                {
                    tbox_client.BeginInvoke(new MethodInvoker(delegate
                    {
                        tbox_client.AppendText(strText + Environment.NewLine);
                    }));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void Send() // 전체 메세지 
        {
            try
            {
                bool bResult = CliChat.SendClick(tbox_send.Text);

                if (bResult)
                {
                    CliChat.Message = tbox_send.Text;
                    tbox_send.Clear();
                }
                else
                {
                    MessageBox.Show("메세지 작성하세요");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void SingleSend() // 귓속말 메세지
        {
            try
            {
                string strId = (string)lbox_member.Items[lbox_member.SelectedIndex];
                CliChat.strSend = tbox_send.Text;
                CliChat.SingleChat(strId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void btn_connect_Click(object sender, EventArgs e) // 서버와 연결
        {
            try
            {
                string strAddress =
                this.tbox_ip1.Text + "." + this.tbox_ip2.Text + "." +
                this.tbox_ip3.Text + "." + this.tbox_ip4.Text;

                int nPort = Convert.ToInt32(this.tbox_port.Text);

                string strName = tbox_name.Text;

                CliChat.Connectt(strAddress, nPort, strName);
                btn_member.Enabled = true;
                CliChat.strName = tbox_name.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btn_send_Click(object sender, EventArgs e)  //전체 메세지 버튼
        {
            try
            {
                if (!CliChat.ConnectClient())
                {
                    MessageBox.Show("Connect를 해주세요");
                    IsInit = false;
                }
                else
                {
                    Send();
                    //box_send.Clear();
                    IsInit = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private void btn_member_Click(object sender, EventArgs e) //귓속말 메세지 버튼
        {
            try
            {
                if (!CliChat.ConnectClient())
                {
                    MessageBox.Show("Connect를 해주세요");
                    IsInit = false;
                }
                else
                {
                    SingleSend();
                    tbox_send.Clear();
                    IsInit = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ClientChat_FormClosing(object sender, FormClosingEventArgs e)
        {

            //    //if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Cancel)
            //    //    e.Cancel = true;

            //byte[] buffer = Encoding.Unicode.GetBytes("채팅종료" + "$");

            //CliChat.Stream.Write(buffer, 0, buffer.Length);
            //CliChat.Stream.Flush();
            //CliChat.Stream.Close();
            //CliChat.Client.Close();

            
            //SerChat.SendMessageAll(strmessage)
            //Application.ExitThread();
            //this.Close();

            //if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Cancel)
            //    e.Cancel = true;

        //    string strId = (string)lbox_member.Items[lbox_member.SelectedIndex];
        //CliChat.strSend = tbox_send.Text;
        //    CliChat.SingleChat(strId );
        }


    private void ListRefresh(string[] strIds) // 리스트박스 아이디
            {
                try
                {
                    if (lbox_member.InvokeRequired)
                    {
                        lbox_member.BeginInvoke(new MethodInvoker(delegate
                        {
                            lbox_member.Items.Clear();

                            foreach (string id in strIds)
                            {
                                lbox_member.Items.Add(id);
                            }
                        }));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

        private void ClientChatting_Load(object sender, EventArgs e)
        {

        }

        //private void ListReSet(string[] strId)
        //{

        //}

        //private void ClientChatting_Load(object sender, EventArgs e)
        //{

        //}

        //private void lbox_member_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
        private void ListReSet(string[] strId) // 리스트박스 아이디
            {
                try
                {
                    if (lbox_member.InvokeRequired)
                    {
                        lbox_member.BeginInvoke(new MethodInvoker(delegate
                        {
                            lbox_member.Items.Clear();

                            foreach (string id in strId)
                            {
                                lbox_member.Items.Add(id);
                            }
                        }));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

    }
}