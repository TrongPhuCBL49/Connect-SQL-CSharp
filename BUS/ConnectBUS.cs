using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ConnectBUS
    {
        private static ConnectBUS instance;

        public static ConnectBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConnectBUS();
                return instance;
            }
        }

        private ConnectBUS() { }
        public bool ConnectDB(string ServerName, string DatabaseName, string UserID, string Password)
        {
            ConnectDTO connectDTO = new ConnectDTO();
            try
            {
                connectDTO.ServerName = ServerName;
                connectDTO.DatabaseName = DatabaseName;
                connectDTO.UserID = UserID;
                connectDTO.Password = Password;
            }
            catch (Exception)
            {
                return false;
            }
            return ConnectDAO.Instance.connectDB(connectDTO);
        }
        public List<string> ListTables()
        {
            return ConnectDAO.Instance.ListTables();
        }
        public DataTable table(string tableName)
        {
            return ConnectDAO.Instance.getTable(tableName);
        }

    }
}
