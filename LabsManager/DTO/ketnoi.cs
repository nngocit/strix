using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.DTO
{
    class ketnoi
    {
        #region Các biến chuỗi kết nối
        string serverName;

        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }
        string databaseName;

        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }
        string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }





        #endregion
    }
}
