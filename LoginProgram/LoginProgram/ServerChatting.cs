using LoginProgram.Mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginProgram
{
    public partial class ServerChatting : Form
    {
         ServerChat SerChat;
        public ServerChatting()
        {
            SerChat = new ServerChat();
            SerChat.DelegateDisplayText += DisplayText;
            InitializeComponent();
        }

        private void DisplayText(string text) // Server 화면에 출력
        {
            try
            {
                if (tbox_server.InvokeRequired)
                {
                    tbox_server.BeginInvoke(new MethodInvoker(
                        delegate ()
                        {
                            tbox_server.AppendText(text + Environment.NewLine);
                        }));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ServerChat_FormClosing(object sender, FormClosingEventArgs e) // 종료
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Cancel)
            e.Cancel = true;
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
