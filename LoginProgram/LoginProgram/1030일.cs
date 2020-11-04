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
        ServerChat schat;
        public ServerChatting()
        {
            schat = new ServerChat();
            schat.DelegateDisplayText += DisplayText;
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
       
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void tbox_server_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ServerChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Cancel)
            e.Cancel = true;
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
