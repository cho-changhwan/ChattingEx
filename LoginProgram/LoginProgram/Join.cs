using LoginProgram.Mysql;
using System;
using System.Windows.Forms;

namespace LoginProgram
{
    public partial class Join : Form
    {
        //Connection m_con = new Connection();
        public Join()
        {
            InitializeComponent();  
        }

        public CRUD m_crud = new CRUD();
        
        private void button1_Click(object sender, EventArgs e)
        {            
            CREATE();            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login m_logf = new Login();
            m_logf.ShowDialog();
            this.Close();
        }

        private void cbox_Passwd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbox_Passwd.Checked == true)
                {
                    tbox_Passwd.PasswordChar = default(char);
                }
                else
                {
                    tbox_Passwd.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void tbox_Id_Enter(object sender, EventArgs e)
        {
            try
            {
                String m_strid = tbox_Id.Text;
                if (m_strid.Equals("id"))
                {
                    tbox_Id.Text = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void tbox_Phone_Enter(object sender, EventArgs e)
        {
            try
            {
                string m_strphone = tbox_Passwd.Text;
                if (m_strphone.Equals("phone"))
                {
                    tbox_Passwd.Text = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void CREATE()
        {
            try
            {
                bool bResult = m_crud.Create_data(tbox_Id.Text, tbox_Passwd.Text, tbox_Phone.Text);

                if (bResult)
                {
                    MessageBox.Show("성공");
                    Console.WriteLine("가입성공");
                    this.Hide();
                    Login m_logf = new Login();
                    m_logf.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("실패");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

        private void Join_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Cancel)

                e.Cancel = true;
            Application.ExitThread();
            Environment.Exit(0);

        }
    }
}
