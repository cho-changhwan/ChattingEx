using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LoginProgram.Mysql
{
    public class Connection
    {
        public MySqlConnection m_con;

        public MySqlConnection Con
        {
            get => m_con;
            set => m_con = value;
        }

        public Connection()
        {
            string strHost = "localhost";
            string strDB = "csi";
            string strPort = "3306";
            string strUser = "root";
            string strPass = "1234";
            string strConstring = "datasource =" + strHost + "; database = " + strDB + "; port = " + strPort + "; username = " + strUser + "; password = " + strPass + "; SslMode=none";
            Con = new MySqlConnection(strConstring);
            Con.Open();
        }
        ~Connection()
        {
            Con.Close();
        }
    }

    public class CRUD : Connection
    {

        public DataTable m_DT = new DataTable();
        private DataSet m_DS = new DataSet();
        public string m_strId;
        public string m_strPasswd;
        public string m_strPhone;
 
        public String strId
        {
            get => m_strId;
            set => m_strId = value;
        }
        public String strPasswd
        {
            get => m_strPasswd;
            set => m_strPasswd = value;
        }
        public String strPhone
        {
            get => m_strPasswd;
            set => m_strPasswd = value;
        }

        public bool Create_data(string strId, string strPasswd, string strPhone) // 회원가입
        {
            bool bResult = false;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "insert into `winform`(`id`, `passwd`, `phone`, `rank`) values (@fid,@fpasswd,@fphone,@frank)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = Con;

                    cmd.Parameters.Add("@fid", MySqlDbType.VarChar).Value = strId;
                    cmd.Parameters.Add("@fpasswd", MySqlDbType.VarChar).Value = strPasswd;
                    cmd.Parameters.Add("@fphone", MySqlDbType.VarChar).Value = strPhone;
                    cmd.Parameters.Add("@frank", MySqlDbType.VarChar).Value = 2;



                    if (Check_Data(strId, strPasswd, strPhone))
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            bResult = true;
                        }
                    }
                    return bResult;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return bResult;
            }
        }


        public int Join_data(string strId, string strPasswd) // 로그인 관리자, 일반회원 
        {
            int bResult = 0;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "select * from `winform` where `id`= @fid and `passwd`= @fpasswd";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = Con;

                    cmd.Parameters.Add("@fid", MySqlDbType.VarChar).Value = strId;
                    cmd.Parameters.Add("@fpasswd", MySqlDbType.VarChar).Value = strPasswd;

                    MySqlDataAdapter mda = new MySqlDataAdapter(cmd);
                    mda.Fill(m_DT);

                    if (JoinCheck(strId, strPasswd))
                    {
                        foreach (DataRow row in m_DT.Rows)
                        {
                            int val = int.Parse(row["Rank"].ToString());

                            if (val == 1)
                            {
                                bResult = 1;
                            }
                            else if (val == 2)
                            {
                                bResult = 2;
                            }
                        }
                    }
                    else
                    {
                        bResult = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                bResult = 0;
            }
            return bResult;
        }

        public bool JoinCheck(String strId, String strPasswd) // 로그인 체크
        {
            bool bResult = false;
            try
            {
                if (m_DT.Rows.Count > 0)
                {
                    bResult = true;
                }
                return bResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return bResult;
            }    
        }
        public bool Insert_data(string strId, string strPasswd, string strPhone) // 회원추가
        {
            bool bResult = false;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.CommandText = "insert into `winform`(`id`, `passwd`, `phone`, `rank`) values (@fid,@fpasswd,@fphone,@frank)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = Con;

                    cmd.Parameters.Add("@fid", MySqlDbType.VarChar).Value = strId;
                    cmd.Parameters.Add("@fpasswd", MySqlDbType.VarChar).Value = strPasswd;
                    cmd.Parameters.Add("@fphone", MySqlDbType.VarChar).Value = strPhone;
                    cmd.Parameters.Add("@frank", MySqlDbType.VarChar).Value = 2;

                    if (Check_Data(strId, strPasswd, strPhone))
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            bResult = true;
                        }
                    }
                    return bResult;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return bResult;
            }
        }
        public bool Update_data(string strId, string strPasswd, string strPhone) // 회원수정
        {
            bool bResult = false;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "update winform set id=@fid, passwd=@fpasswd, phone=@fphone where id =@fid";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = Con;

                    cmd.Parameters.Add("@fid", MySqlDbType.VarChar).Value = strId;
                    cmd.Parameters.Add("@fpasswd", MySqlDbType.VarChar).Value = strPasswd;
                    cmd.Parameters.Add("@fphone", MySqlDbType.VarChar).Value = strPhone;
                    if (!CheckAll(strId, strPasswd, strPhone))
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            bResult = true;
                        }
                    }
                    return bResult;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return bResult;
            }
        }

        public bool Delete_data(String strId) // 회원삭제, 아이디로만
        {
            bool bResult = false;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "delete from winform where id=@fid";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = Con;

                    cmd.Parameters.Add("@fid", MySqlDbType.VarChar).Value = strId;

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        bResult = true;
                    }
                    return bResult;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return bResult;
            }
        }

        public void Read_data() // 데이터 
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    m_DT.Clear();
                    string query = "select * from `winform`";
                    MySqlDataAdapter mda = new MySqlDataAdapter(query, Con);
                    mda.Fill(m_DS);
                    m_DT = m_DS.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public Boolean IdCheck(string strId) //중복아이디 체크
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter mda = new MySqlDataAdapter();

                MySqlCommand cmd = new MySqlCommand("select * from `winform` where `id` = @fid", Con);
                cmd.Parameters.Add("@fid", MySqlDbType.VarChar).Value = strId;

                mda.SelectCommand = cmd;
                mda.Fill(dt);

                if (dt.Rows.Count > 0)
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
                return false;
            }
           
        }

        public Boolean CheckAll(string strId, string strPasswd, string strPhone) //빈칸체크용
        {
            try
            {
                if (string.IsNullOrEmpty(strId) || string.IsNullOrEmpty(strPasswd) || string.IsNullOrEmpty(strPhone))
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
                return false;
            }
        }

        public bool Check_Data(string strId, string strPasswd, string strPhone) //중복아이디 빈칸체크용
        {
            bool bResult = false;
            try
            {
                if (!CheckAll(strId, strPasswd, strPhone))
                {
                    if (!IdCheck(strId))
                    {
                        bResult = true;
                    }
                    else
                    {
                        Console.WriteLine("중복아이디가 있습니다.");
                    }
                }
                else
                {
                    Console.WriteLine("전체 작성하지 않았습니다.");
                }
                return bResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return bResult;
            }
        }
    }
}