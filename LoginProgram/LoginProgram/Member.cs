using LoginProgram.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LoginProgram
{
    public partial class Member : Form
    {
        Connection mcon = new Connection();
        CRUD m_crud = new CRUD();
        public Member()
        {
            InitializeComponent();
        }
        private void Member_Load(object sender, EventArgs e) //데이터 그리드뷰 열 이름변경
        {
            load_table();
            this.datag_view1.Columns[0].HeaderText = "회원 아이디";
            this.datag_view1.Columns[1].HeaderText = "회원 비밀번호";
            this.datag_view1.Columns[2].HeaderText = "회원 전화번호";
        }
        public void READ() // DB 데이터 읽기
        {
            try
            {
                datag_view1.DataSource = null;
                m_crud.Read_data();
                datag_view1.DataSource = m_crud.m_DT;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        public void Insert() // 회원추가 
        {
            try
            {
                bool bResult = m_crud.Insert_data(tbox_mId.Text, tbox_mPasswd.Text, tbox_mPhone.Text);
                if (bResult)
                {
                    MessageBox.Show("성공");
                    Console.WriteLine("가입성공");
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

        private void button4_Click(object sender, EventArgs e) // 회원추가 버튼
        {
            Insert();
            READ();
            load_table();
        }

        public void UPDATE() // 회원수정
        {
            try
            {
                bool bResult = m_crud.Update_data(tbox_mId.Text, tbox_mPasswd.Text, tbox_mPhone.Text);
                if (bResult)
                {
                    MessageBox.Show("성공");
                    Console.WriteLine("수정성공");
                }
                else
                {
                    MessageBox.Show("실패");
                    Console.WriteLine("전체 작성하지 않았습니다.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btn_mUpdate_Click(object sender, EventArgs e) // 회원수정 버튼
        {
            UPDATE();
            READ();
            load_table();
            tbox_mId.Clear();
            tbox_mPasswd.Clear();
            tbox_mPhone.Clear();
        }

        public void DELETE() // 회원삭제
        {
            try
            {
                bool bResult = m_crud.Delete_data(tbox_mId.Text);
                if (bResult)
                {
                    MessageBox.Show("성공");
                    Console.WriteLine("삭제성공");
                }
                else
                {
                    MessageBox.Show("실패");
                    Console.WriteLine("없는 아이디");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btn_mDelete_Click(object sender, EventArgs e) // 회원삭제 버튼
        {
            DELETE();
            READ();
            load_table();

            tbox_mId.Clear();
            tbox_mPasswd.Clear();
            tbox_mPhone.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e) // 아이디로 회원찾기 버튼
        {
            try
            {
                DataTable dt = new DataTable();
                string strquery = "select * from winform where id = '" + tbox_mId.Text + "'";
                m_crud.strId = tbox_mId.Text;
                MySqlDataAdapter dadt = new MySqlDataAdapter(strquery,
                                                 mcon.m_con);
                dadt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    datag_view1.DataSource = dt;
                    Console.WriteLine("회원찾기 완료");
                }
                else
                {
                    MessageBox.Show("없는 회원 아이디 입니다.");
                    Console.WriteLine("존재하지 않는 회원");
                    load_table();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void datag_view1_MouseClick(object sender, MouseEventArgs e) // 데이터 그리드뷰 마우스클릭시 정보 가져오기
        {
            tbox_mId.Text = datag_view1.CurrentRow.Cells[0].Value.ToString();
            tbox_mPasswd.Text = datag_view1.CurrentRow.Cells[1].Value.ToString();
            tbox_mPhone.Text = datag_view1.CurrentRow.Cells[2].Value.ToString();
        }


        private void btn_allmem_Click(object sender, EventArgs e) // 전체회원 보여주기 버튼
        {
            load_table();
            Console.WriteLine("전체회원");
        }

        private void btn_chat_Click(object sender, EventArgs e) // 채팅화면이동 버튼
        {
            Console.WriteLine("채팅화면 이동");
            this.Hide();
            MainChat chat = new MainChat();
            chat.ShowDialog();
        }

        public void load_table() // 데이터 읽어 그리드뷰에 보여주기
        {
            try
            {
                string strquery = "select * from winform";
                DataTable dt = new DataTable();
                MySqlDataAdapter dadt = new MySqlDataAdapter(strquery,
                                                             mcon.m_con);
                dadt.Fill(dt);
                datag_view1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private void Member_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Cancel)

                e.Cancel = true;
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
