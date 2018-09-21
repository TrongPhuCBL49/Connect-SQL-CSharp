using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ConnectDTO
    {
        private string _serverName;
        private string _databaseName;
        private string _userID;
        private string _password;

        public string ServerName { get => _serverName; set => _serverName = value; }
        public string DatabaseName { get => _databaseName; set => _databaseName = value; }
        public string UserID { get => _userID; set => _userID = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
