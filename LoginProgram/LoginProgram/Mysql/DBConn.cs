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
            string host = "localhost";
            string db = "csi";
            string port = "3306";
            string user = "root";
            string pass = "1234";
            string constring = "datasource =" + host + "; database = " + db + "; port = " + port + "; username = " + user + "; password = " + pass + "; SslMode=none";
            m_con = new MySqlConnection(constring);
            m_con.Open();
        }
        ~Connection()
        {
            m_con.Close();
        }
    }

    public class CRUD : Connection
    {

        public DataTable m_DT = new DataTable();
        private DataSet m_DS = new DataSet();
        public Join m_joform;
        public Login m_loginform;

        public string m_strId;
        public string m_strPasswd;
        public string m_strPhone;
        public string m_strList;
        public int in_Rank;
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

        public int nRank
        {
            get => in_Rank;
            set => in_Rank = value;
        }
        public bool Insert_data(string strId, string strPasswd, string strPhone)
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

        public bool Check_Data(string strId, string strPasswd, string strPhone)
        {
            bool bResult = false;
            try
            {
                if (!CheckAll(strId, strPasswd, strPhone))
                {
                    if (!idcheck(strId))
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


        public bool Create_data(string strId, string strPasswd, string strPhone)
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


        public int Join_data(string strId, string strPasswd)
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

                    //cmd.ExecuteNonQuery();
                    //MySqlDataReader mdr = cmd.ExecuteReader();
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

        public bool JoinCheck(String strId, String strPasswd)
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

        public bool Update_data(string strId, string strPasswd, string strPhone)
        {
            bool bResult = false;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "update winform set id=@fid, passwd=@fpasswd, phone=@fphone where id =@fid";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = m_con;

                    cmd.Parameters.Add("@fid", MySqlDbType.VarChar).Value = strId;
                    cmd.Parameters.Add("@fpasswd", MySqlDbType.VarChar).Value = strPasswd;
                    cmd.Parameters.Add("@fphone", MySqlDbType.VarChar).Value = strPhone;
                    if (!UCheckAll(strId, strPasswd, strPhone))
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

        public bool Delete_data(String strId)
        {
            bool bResult = false;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "delete from winform where id=@fid";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = m_con;

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

        public void Read_data()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    m_DT.Clear();
                    string query = "select * from `winform`";
                    MySqlDataAdapter mda = new MySqlDataAdapter(query, m_con);
                    mda.Fill(m_DS);
                    m_DT = m_DS.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public Boolean idcheck(string strId)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter mda = new MySqlDataAdapter();

                MySqlCommand cmd = new MySqlCommand("select * from `winform` where `id` = @fid", m_con);
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
        public Boolean CheckAll(string strId, string strPasswd, string strPhone)
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
        
        public Boolean UCheckAll(string strId, string strPasswd, string strPhone)
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
    }
}