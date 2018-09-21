using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class ConnectDAO
    {
        private static ConnectDAO instance;
        public static ConnectDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConnectDAO();
                return instance;
            }
        }

        SqlConnection con;
        SqlDataAdapter dap;
        SqlCommand cmd;

        private ConnectDAO() { }

        //Kết nối
        public bool connectDB(ConnectDTO connectDTO)
        {
            string strCon = "Data Source=" + connectDTO.ServerName + ";" +
                            "Initial Catalog=" + connectDTO.DatabaseName + ";" +
                            "User id=" + connectDTO.UserID + ";" +
                            "Password=" + connectDTO.Password + ";";
            con = new SqlConnection(strCon);
            cmd = con.CreateCommand();
            try
            {
                con.Open();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Dispose();
                return false;
            }
            return true;
        }
        public List<string> ListTables()
        {
            con.Open();
            List<string> tables = new List<string>();
            DataTable dt = con.GetSchema("Tables");
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                tables.Add(tablename);
            }
            con.Close();
            return tables;
        }
        //Thực hiện câu lệnh sql trả về bảng dữ liệu
        public DataTable getTable(string tableName)
        {
            DataTable tbl = new DataTable();
            string query = "Select * From " + tableName + ";";
            dap = new SqlDataAdapter(query, con);
            dap.Fill(tbl);
            return tbl;
        }
    }
}
