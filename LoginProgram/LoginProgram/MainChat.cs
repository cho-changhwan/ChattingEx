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
    public partial class MainChat : Form
    {
        public CRUD m_crud = new CRUD();
        private string m_Id;
        private Connection mCon;
        public MainChat()
        {
            InitializeComponent();
            Load += MdiMain_Load;
        }
        public MainChat(string id, Connection Con)
        {
            InitializeComponent();
            Load += MdiMain_Load;
            m_Id = id;
            mCon = Con;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login m_logf = new Login();
            m_logf.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientChatting client = new ClientChatting(m_Id, mCon);
            client.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerChatting server = new ServerChatting();
            server.Show();
            btn_server.Enabled = false;
        }
        private void MainChat_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Cancel)
                e.Cancel = true;
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void MdiMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
