using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginProgram.Mysql;
using MySql.Data.MySqlClient;

namespace LoginProgram
{
    public partial class Login : Form
    {

        Connection m_con = new Connection();
        public CRUD m_crud = new CRUD();
        Member m_memf = new Member();

        public Login()
        {
            InitializeComponent();   
        }

        private void btn_Join_Click(object sender, EventArgs e)
        {
            this.Hide();
            Join jof = new Join();
            jof.ShowDialog();
            this.Close();
        }

        public void Join()
        {
            try
            {
                int bResult = m_crud.Join_data(tbox_lId.Text, tbox_lPasswd.Text);
                if (bResult != 0)
                {
                    if (bResult == 1)
                    {
                        MessageBox.Show("관리자님" + " 반갑습니다");
                        Console.WriteLine("로그인성공");
                        this.Hide();
                        m_memf.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(tbox_lId.Text + "님 반갑습니다");
                        Console.WriteLine("로그인성공");
                        this.Hide();
                        this.Hide();
                        ClientChatting Client = new ClientChatting(tbox_lId.Text, m_con);
                        Client.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("실패");
                    Console.WriteLine("아이디 or 비밀번호 불일치");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Join();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Cancel)
                e.Cancel = true;
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
